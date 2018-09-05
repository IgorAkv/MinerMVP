namespace Akimov.MinerMVP.Views {
    partial class MinerView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinerView));
            this.picMineField = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.itemNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMineField)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMineField
            // 
            this.picMineField.BackColor = System.Drawing.Color.Black;
            this.picMineField.Location = new System.Drawing.Point(0, 24);
            this.picMineField.Margin = new System.Windows.Forms.Padding(0);
            this.picMineField.Name = "picMineField";
            this.picMineField.Size = new System.Drawing.Size(181, 105);
            this.picMineField.TabIndex = 0;
            this.picMineField.TabStop = false;
            // 
            // menu
            // 
            this.menu.AllowMerge = false;
            this.menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNewGame,
            this.itemSettings,
            this.itemExit});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 24);
            this.menu.TabIndex = 1;
            // 
            // itemNewGame
            // 
            this.itemNewGame.Name = "itemNewGame";
            this.itemNewGame.Size = new System.Drawing.Size(77, 20);
            this.itemNewGame.Text = "&New Game";
            this.itemNewGame.Click += new System.EventHandler(this.itemNewGame_Click);
            // 
            // itemSettings
            // 
            this.itemSettings.Name = "itemSettings";
            this.itemSettings.Size = new System.Drawing.Size(61, 20);
            this.itemSettings.Text = "&Settings";
            this.itemSettings.Click += new System.EventHandler(this.itemSettings_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(37, 20);
            this.itemExit.Text = "&Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // MinerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(181, 130);
            this.Controls.Add(this.picMineField);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MinerView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineField";
            ((System.ComponentModel.ISupportInitialize)(this.picMineField)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMineField;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem itemNewGame;
        private System.Windows.Forms.ToolStripMenuItem itemSettings;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
    }
}