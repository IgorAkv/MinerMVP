﻿using Akimov.MinerMVP.Models;
using Akimov.MinerMVP.Presenters;
using Akimov.MinerMVP.Views;
using System;
using System.Windows.Forms;

namespace Akimov.MinerMVP {
    public partial class LauncherForm : Form {
        public LauncherForm() {
            InitializeComponent();
            boxHeight.Text = MineFieldConstants.HEIGHT_EASY.ToString();
            textBoxWidth.Text = MineFieldConstants.WIDTH_EASY.ToString();
            textBoxBombRatio.Text = MineFieldConstants.BOMB_RATIO_EASY.ToString();
            chBoxCommanderMode.Checked = false;
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
            MinerView minerView = new MinerView();      
            MinerPresenter presenter = new MinerPresenter(minerView);
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
