using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Presenters;
using Akimov.MinerMVP.Views;
using System;
using System.Windows.Forms;

namespace Akimov.MinerMVP {
    public partial class LauncherForm : Form {
        public LauncherForm() {
            InitializeComponent();
            boxHeight.Text = MineFieldConstant.HEIGHT_EASY.ToString();
            textBoxWidth.Text = MineFieldConstant.WIDTH_EASY.ToString();
            textBoxBombRatio.Text = MineFieldConstant.BOMB_RATIO_EASY.ToString();
            chBoxCommanderMode.Checked = false;
        }

        public int Rows {
            get {
                int h = MineFieldConstant.HEIGHT_EASY;
                Int32.TryParse(boxHeight.Text, out h);
                return h;
            }
        }
        public int Columns {
            get {
                int w = MineFieldConstant.WIDTH_EASY;
                Int32.TryParse(textBoxWidth.Text, out w);
                return w;
            }
        }
        public int BombRatio {
            get {
                int r = MineFieldConstant.BOMB_RATIO_EASY;
                Int32.TryParse(textBoxBombRatio.Text, out r);
                return r;
            }
        }

        public bool CommanderMode {
            get {
                return chBoxCommanderMode.Checked;
            }
        }

        void rBtnEasy_CheckedChanged(object sender, EventArgs e) {
            if (rBtnEasy.Checked) {                
                SetParameters(MineFieldConstant.WIDTH_EASY, MineFieldConstant.HEIGHT_EASY, MineFieldConstant.BOMB_RATIO_EASY);
            }
        }

        void rBtnExpert_CheckedChanged(object sender, EventArgs e) {
            if (rBtnExpert.Checked) {
                SetParameters(MineFieldConstant.WIDTH_EXPERT, MineFieldConstant.HEIGHT_EXPERT, MineFieldConstant.BOMB_RATIO_EXPERT);
            }
        }

        void rBtnMedium_CheckedChanged(object sender, EventArgs e) {
            if (rBtnMedium.Checked) {
                SetParameters(MineFieldConstant.WIDTH_MEDIUM, MineFieldConstant.HEIGHT_MEDIUM, MineFieldConstant.BOMB_RATIO_MEDIUM);
            }
        }

        void rBtnSpecial_CheckedChanged(object sender, EventArgs e) {
            textBoxWidth.Enabled = true;
            boxHeight.Enabled = true;
            textBoxBombRatio.Enabled = true;
            chBoxCommanderMode.Enabled = true;
        }

        void SetParameters(int width, int height, int bombRatio) {
            textBoxWidth.Text = width.ToString();
            boxHeight.Text = height.ToString();
            textBoxBombRatio.Text = bombRatio.ToString();
            boxHeight.Enabled = false;
            textBoxWidth.Enabled = false;
            textBoxBombRatio.Enabled = false;
            chBoxCommanderMode.Checked = false;
            chBoxCommanderMode.Enabled = false;
        }
                        
        void btnOk_Click(object sender, EventArgs e) {
            MineFieldSettings setting = new MineFieldSettings(Rows, Columns, BombRatio, CommanderMode);
            MinerView minerView = new MinerView(setting);
            GameOverView gameOverView = new GameOverView();
            MinerModel model = new MinerModel(setting);
            MinerPresenter presenter = new MinerPresenter(minerView, gameOverView, model);
            this.Hide();            
            presenter.Start();
            minerView.ShowDialog();
            this.Show();
        }

        void btn_Exit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
