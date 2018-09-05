using Akimov.MinerMVP.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Akimov.MinerMVP.Views {
    public partial class GameOverView : Form, IGameOverView {
        public GameOverView() {
            InitializeComponent();
            this.Hide();
        }

        public void ShowGameOver(GameOverType type) {
            string message = string.Empty;
            Image image;

            switch (type) {
            case GameOverType.Victory:
                message = UIConstants.MSG_VICTORY;                    
                image = Properties.Resources.VictorySoldier;
                break;
            case GameOverType.VictoryCommander:
                message = UIConstants.MSG_VICTORY_COMMANDER;                    
                image = Properties.Resources.VictoryCommander;
                break;
            case GameOverType.Defeat:
                message = UIConstants.MSG_DEFEAT;
                image = Properties.Resources.Defeat;
                break;
            default:
                throw new InvalidEnumArgumentException();
            }

            btnClose.Image = image;
            messageBox.Text = message;
            this.ShowDialog();
        }

        void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
