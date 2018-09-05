using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Presenters;
using Akimov.MinerMVP.Views;
using System;
using System.Windows.Forms;

namespace Akimov.MinerMVP.Views {
    public partial class SettingView : Form {
        Action<MineFieldSettings> SetSetting;
        public SettingView(MineFieldSettings settings, Action<MineFieldSettings> setSetting) {
            InitializeComponent();
            this.SetSetting = setSetting;
            boxHeight.Text = settings.Rows.ToString();
            textBoxWidth.Text = settings.Columns.ToString();
            textBoxBombRatio.Text = settings.BombRatio.ToString();                
            chBoxCommanderMode.Checked = settings.CommanderMode;

            rBtnSpecial.Checked = settings.CommanderMode;
        }

        public int Rows {
            get {
                int h = MineFieldConstants.HEIGHT_EASY;
                Int32.TryParse(boxHeight.Text, out h);
                return h;
            }
        }
        public int Columns {
            get {
                int w = MineFieldConstants.WIDTH_EASY;
                Int32.TryParse(textBoxWidth.Text, out w);
                return w;
            }
        }
        public int BombRatio {
            get {
                int r = MineFieldConstants.BOMB_RATIO_EASY;
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
                SetParameters(MineFieldConstants.WIDTH_EASY, MineFieldConstants.HEIGHT_EASY, MineFieldConstants.BOMB_RATIO_EASY);
            }
        }

        void rBtnExpert_CheckedChanged(object sender, EventArgs e) {
            if (rBtnExpert.Checked) {
                SetParameters(MineFieldConstants.WIDTH_EXPERT, MineFieldConstants.HEIGHT_EXPERT, MineFieldConstants.BOMB_RATIO_EXPERT);
            }
        }

        void rBtnMedium_CheckedChanged(object sender, EventArgs e) {
            if (rBtnMedium.Checked) {
                SetParameters(MineFieldConstants.WIDTH_MEDIUM, MineFieldConstants.HEIGHT_MEDIUM, MineFieldConstants.BOMB_RATIO_MEDIUM);
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
            SetSetting(new MineFieldSettings(Rows, Columns, BombRatio, CommanderMode));
            Close();
        }       
    }
}
