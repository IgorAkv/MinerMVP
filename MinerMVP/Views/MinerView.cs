using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Akimov.MinerMVP.Views {
    public partial class MinerView : Form, IMinerView {
        static Dictionary<CellType, Image> images = new Dictionary<CellType, Image>() {
            { CellType.Bomb, Resources.Bomb},
            { CellType.Closed, Resources.Closed},
            { CellType.Flagged, Resources.Flagged},
            { CellType.None_Bomb_Around, Resources.Empty},
            { CellType.One_Bomb_Around, Resources.One},
            { CellType.Two_Bomb_Around, Resources.Two},
            { CellType.Three_Bomb_Around, Resources.Three},
            { CellType.Four_Bomb_Around, Resources.Four},
            { CellType.Five_Bomb_Around, Resources.Five},
            { CellType.Six_Bomb_Around, Resources.Six},
            { CellType.Seven_Bomb_Around, Resources.Seven},
            { CellType.Eight_Bomb_Around, Resources.Eight}};
        const int CELL_SIZE = 33;
        public event EventHandler<CellActionArgs> CellAction = delegate { };
        Bitmap bufferForPaint;
        List<Cell> updatedCells;

        public MinerView(MineFieldSettings setting) {
            InitializeComponent();
            Settings = setting;
            PrepareMineField();
        }

        MineFieldSettings Settings { get; }

        void PrepareMineField() {
            MaximumSize = Screen.PrimaryScreen.Bounds.Size;
            picMineField.Size = new Size(
                Settings.Columns * CELL_SIZE + 1,
                Settings.Rows * CELL_SIZE + 1);
            Text = String.Format(Localizer.MINER_VIEW_NAME, Settings.Columns, Settings.Rows);                
            SubscribeEvents();
        }

        void SubscribeEvents() {
            picMineField.Paint += PaintMineField;
            picMineField.MouseUp += MineField_MouseUp;
        }

        void MineField_MouseUp(object sender, MouseEventArgs e) {
            int row = e.Y / CELL_SIZE;
            int column = e.X / CELL_SIZE;
            if (e.Button == MouseButtons.Left) {
                OnCellAction(new CellActionArgs(row, column, CellActionType.Open));
            }
            if (e.Button == MouseButtons.Right) {
                OnCellAction(new CellActionArgs(row, column, CellActionType.NextMarker));
            }
        }

        void SetMaximumSizeView() {
            this.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
        }

        void PaintMineField(object sender, PaintEventArgs e) {
            if (updatedCells == null) {
                return;
            }
            if (bufferForPaint == null) {
                bufferForPaint = new Bitmap(picMineField.Width, picMineField.Height);
            }
            using (Graphics g = Graphics.FromImage(bufferForPaint)) {
                foreach (Cell cell in updatedCells) {
                    g.DrawImage(images[cell.CellType],
                        CELL_SIZE * cell.Position.Column + 1,
                        CELL_SIZE * cell.Position.Row + 1);
                }
            }
            picMineField.Cursor = Cursors.Default;
            picMineField.Image = bufferForPaint;
        }

        public void MineFieldUpdate(List<Cell> updatedCells) {
            this.updatedCells = updatedCells;
            Refresh();
        }

        void OnCellAction(CellActionArgs e) {
            picMineField.Cursor = Cursors.WaitCursor;
            CellAction(this, e);
        }

        public void GameOver() {
            UnSubscribeEvents();
            this.Close();
        }

        void UnSubscribeEvents() {
            picMineField.Paint -= PaintMineField;
            picMineField.MouseUp -= MineField_MouseUp;
        }
    }
}
