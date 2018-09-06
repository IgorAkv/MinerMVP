using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Presenters;
using Akimov.MinerMVP.Views;
using System;
using System.Windows.Forms;

namespace Akimov.MinerMVP.Views {
    public partial class SettingForm : Form {
        Action<MineFieldSettings> SetSetting;
       
        public SettingForm(MineFieldSettings settings, Action<MineFieldSettings> actionSetSetting) {
            InitializeComponent();
            this.SetSetting = actionSetSetting;
            txtRows.Text = settings.Rows.ToString();
            txtColumns.Text = settings.Columns.ToString();
            txtBombRatio.Text = settings.BombRatio.ToString();                
            chBoxCommanderMode.Checked = settings.CommanderMode;
            SetDifficultyLevel(settings);
        }
       
        void SetDifficultyLevel(MineFieldSettings settings) {
            if (settings.Rows == MineFieldConstants.ROWS_EASY &&
                settings.Columns == MineFieldConstants.COLUMNS_EASY &&
                settings.BombRatio == MineFieldConstants.BOMB_RATIO_EASY &&
                !settings.CommanderMode) {
                rBtnEasy.Checked = true;
                return;
            }
            if (settings.Rows == MineFieldConstants.ROWS_MEDIUM &&
                settings.Columns == MineFieldConstants.COLUMNS_MEDIUM &&
                settings.BombRatio == MineFieldConstants.BOMB_RATIO_MEDIUM &&
                !settings.CommanderMode) {
                rBtnMedium.Checked = true;
                return;
            }
            if (settings.Rows == MineFieldConstants.ROWS_EXPERT &&
               settings.Columns == MineFieldConstants.COLUMNS_EXPERT &&
               settings.BombRatio == MineFieldConstants.BOMB_RATIO_EXPERT &&
               !settings.CommanderMode) {
                rBtnExpert.Checked = true;
                return;
            }
            rBtnSpecial.Checked = true;
        }

        int Rows {
            get {
                int r = MineFieldConstants.ROWS_EASY;
                Int32.TryParse(txtRows.Text, out r);
                return r;
            }
        }
        int Columns {
            get {
                int c = MineFieldConstants.COLUMNS_EASY;
                Int32.TryParse(txtColumns.Text, out c);
                return c;
            }
        }
        int BombRatio {
            get {
                int b = MineFieldConstants.BOMB_RATIO_EASY;
                Int32.TryParse(txtBombRatio.Text, out b);
                return b;
            }
        }

        bool CommanderMode {
            get {
                return chBoxCommanderMode.Checked;
            }
        }

        void rBtnEasy_CheckedChanged(object sender, EventArgs e) {
            if (rBtnEasy.Checked) {                
                SetParameters(MineFieldConstants.COLUMNS_EASY, MineFieldConstants.ROWS_EASY, MineFieldConstants.BOMB_RATIO_EASY);
            }
        }

        void rBtnExpert_CheckedChanged(object sender, EventArgs e) {
            if (rBtnExpert.Checked) {
                SetParameters(MineFieldConstants.COLUMNS_EXPERT, MineFieldConstants.ROWS_EXPERT, MineFieldConstants.BOMB_RATIO_EXPERT);
            }
        }

        void rBtnMedium_CheckedChanged(object sender, EventArgs e) {
            if (rBtnMedium.Checked) {
                SetParameters(MineFieldConstants.COLUMNS_MEDIUM, MineFieldConstants.ROWS_MEDIUM, MineFieldConstants.BOMB_RATIO_MEDIUM);
            }
        }

        void rBtnSpecial_CheckedChanged(object sender, EventArgs e) {
            txtColumns.Enabled = true;
            txtRows.Enabled = true;
            txtBombRatio.Enabled = true;
            chBoxCommanderMode.Enabled = true;
        }

        void SetParameters(int width, int height, int bombRatio) {
            txtColumns.Text = width.ToString();
            txtRows.Text = height.ToString();
            txtBombRatio.Text = bombRatio.ToString();
            txtRows.Enabled = false;
            txtColumns.Enabled = false;
            txtBombRatio.Enabled = false;
            chBoxCommanderMode.Checked = false;
            chBoxCommanderMode.Enabled = false;
        }
       
        void btnOk_Click(object sender, EventArgs e) {
            SetSetting(new MineFieldSettings(Rows, Columns, BombRatio, CommanderMode));
            Close();
        }       
    }
}
