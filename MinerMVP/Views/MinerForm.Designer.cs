namespace Akimov.MinerMVP.Views {
    partial class MinerForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinerForm));
            this.picBoxMineField = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.itemNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMineField)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxMineField
            // 
            this.picBoxMineField.BackColor = System.Drawing.Color.Black;
            this.picBoxMineField.Location = new System.Drawing.Point(0, 24);
            this.picBoxMineField.Margin = new System.Windows.Forms.Padding(0);
            this.picBoxMineField.Name = "picBoxMineField";
            this.picBoxMineField.Size = new System.Drawing.Size(181, 105);
            this.picBoxMineField.TabIndex = 0;
            this.picBoxMineField.TabStop = false;
            // 
            // menu
            // 
            this.menu.AllowMerge = false;
            this.menu.GripMargin = new System.Windows.Forms.Padding(0);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNewGame,
            this.itemSettings,
            this.itemExit});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 24);
            this.menu.TabIndex = 1;
            // 
            // itemNewGame
            // 
            this.itemNewGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.itemNewGame.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemNewGame.Name = "itemNewGame";
            this.itemNewGame.Size = new System.Drawing.Size(77, 20);
            this.itemNewGame.Text = "&New Game";
            // 
            // itemSettings
            // 
            this.itemSettings.Name = "itemSettings";
            this.itemSettings.Size = new System.Drawing.Size(61, 20);
            this.itemSettings.Text = "&Settings";
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(37, 20);
            this.itemExit.Text = "&Exit";
            // 
            // MinerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(181, 130);
            this.Controls.Add(this.picBoxMineField);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MinerView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MineField";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMineField)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMineField;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem itemNewGame;
        private System.Windows.Forms.ToolStripMenuItem itemSettings;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
    }
}