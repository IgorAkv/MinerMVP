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
            this.picMineField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMineField)).BeginInit();
            this.SuspendLayout();
            // 
            // picMineField
            // 
            this.picMineField.BackColor = System.Drawing.Color.Black;
            this.picMineField.Location = new System.Drawing.Point(1, 0);
            this.picMineField.Name = "picMineField";
            this.picMineField.Size = new System.Drawing.Size(181, 105);
            this.picMineField.TabIndex = 0;
            this.picMineField.TabStop = false;
            // 
            // MinerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(184, 106);
            this.Controls.Add(this.picMineField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MinerView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MineField";
            ((System.ComponentModel.ISupportInitialize)(this.picMineField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMineField;
    }
}