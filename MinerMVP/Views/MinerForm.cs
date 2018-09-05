using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Akimov.MinerMVP.Views {
    public partial class MinerForm : Form, IMinerForm {
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
        const int CELL_SIZE = BORDER_WIDTH + 32;
        const int BORDER_WIDTH = 1;
        public event EventHandler<CellActionArgs> CellAction = delegate { };
        public event EventHandler Settings = delegate { };
        public event EventHandler NewGame = delegate { };
        public event EventHandler Exit = delegate { };

        Bitmap bufferForPaint;
        List<Cell> updatedCells;
        MineFieldSettings settings;

        public MinerForm() {
            InitializeComponent();
            SubscribeMenuEvents();
        }

        public void StartNewGame(MineFieldSettings setting) {            
            settings = setting;
            PrepareMineField();
        }

        public void MineFieldUpdate(List<Cell> updatedCells) {
            this.updatedCells = updatedCells;
            Refresh();
        }

        public void GameOver() {
            UnSubscribeMouseEvent();
            picBoxMineField.Cursor = Cursors.No;
            itemNewGame.Select();            
        }

        void PrepareMineField() {
            UnSubscribePaintEvents();
            UnSubscribeMouseEvent();
            bufferForPaint = null;
            picBoxMineField.Size = new Size(
                settings.Columns * CELL_SIZE + BORDER_WIDTH,
                settings.Rows * CELL_SIZE + BORDER_WIDTH);
            this.Size = Size.Empty;
            //this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
            //    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            Text = String.Format(UIConstants.MINER_VIEW_NAME, settings.Columns, settings.Rows);                
            
            picBoxMineField.Cursor = Cursors.Default;
            SubscribePaintEvents();
            SubscribeMouseEvent();
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
        
        void PaintMineField(object sender, PaintEventArgs e) {
            if (updatedCells == null) {
                return;
            }
            if (bufferForPaint == null) {
                bufferForPaint = new Bitmap(picBoxMineField.Width, picBoxMineField.Height);
            }
            using (Graphics g = Graphics.FromImage(bufferForPaint)) {
                foreach (Cell cell in updatedCells) {
                    g.DrawImage(images[cell.CellType],
                        CELL_SIZE * cell.Position.Column + BORDER_WIDTH,
                        CELL_SIZE * cell.Position.Row + BORDER_WIDTH);
                }
            }            
            picBoxMineField.Image = bufferForPaint;
        }
        void OnCellAction(CellActionArgs e) {
            CellAction(this, e);
        }

        void OnNewGame(object sender, EventArgs e) {
            NewGame(this, null);            
        }

        void OnSettings(object sender, EventArgs e) {
            Settings(this, null);
        }
                
        void OnExit(object sender, EventArgs e) {
            Exit(this, null);
            UnSubscribeMenuEvents();
            Close();
        }

        void SubscribeMenuEvents() {
            itemNewGame.Click += OnNewGame;
            itemSettings.Click += OnSettings;
            itemExit.Click += OnExit;
        }
        void UnSubscribeMenuEvents() {
            itemNewGame.Click -= OnNewGame;
            itemSettings.Click -= OnSettings;
            itemExit.Click -= OnExit;
        }
        void UnSubscribePaintEvents() {
            picBoxMineField.Paint -= PaintMineField;
        }
        void SubscribePaintEvents() {
            picBoxMineField.Paint += PaintMineField;
        }
        void SubscribeMouseEvent() {
            picBoxMineField.MouseUp += MineField_MouseUp;
        }
        void UnSubscribeMouseEvent() {
            picBoxMineField.MouseUp -= MineField_MouseUp;
        }

    }
}
