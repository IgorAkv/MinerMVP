namespace Akimov.MinerMVP.Views {
    partial class SettingView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnSpecial = new System.Windows.Forms.RadioButton();
            this.rBtnExpert = new System.Windows.Forms.RadioButton();
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.boxHeight = new System.Windows.Forms.MaskedTextBox();
            this.textBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.textBoxBombRatio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBoxCommanderMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnSpecial);
            this.groupBox1.Controls.Add(this.rBtnExpert);
            this.groupBox1.Controls.Add(this.rBtnMedium);
            this.groupBox1.Controls.Add(this.rBtnEasy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(7, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty level";
            // 
            // rBtnSpecial
            // 
            this.rBtnSpecial.AutoSize = true;
            this.rBtnSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtnSpecial.Location = new System.Drawing.Point(18, 147);
            this.rBtnSpecial.Name = "rBtnSpecial";
            this.rBtnSpecial.Size = new System.Drawing.Size(121, 35);
            this.rBtnSpecial.TabIndex = 8;
            this.rBtnSpecial.Text = "Special";
            this.rBtnSpecial.UseVisualStyleBackColor = true;
            this.rBtnSpecial.CheckedChanged += new System.EventHandler(this.rBtnSpecial_CheckedChanged);
            // 
            // rBtnExpert
            // 
            this.rBtnExpert.AutoSize = true;
            this.rBtnExpert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtnExpert.Location = new System.Drawing.Point(18, 106);
            this.rBtnExpert.Name = "rBtnExpert";
            this.rBtnExpert.Size = new System.Drawing.Size(110, 35);
            this.rBtnExpert.TabIndex = 7;
            this.rBtnExpert.Text = "Expert";
            this.rBtnExpert.UseVisualStyleBackColor = true;
            this.rBtnExpert.CheckedChanged += new System.EventHandler(this.rBtnExpert_CheckedChanged);
            // 
            // rBtnMedium
            // 
            this.rBtnMedium.AutoSize = true;
            this.rBtnMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtnMedium.Location = new System.Drawing.Point(18, 65);
            this.rBtnMedium.Name = "rBtnMedium";
            this.rBtnMedium.Size = new System.Drawing.Size(127, 35);
            this.rBtnMedium.TabIndex = 6;
            this.rBtnMedium.Text = "Medium";
            this.rBtnMedium.UseVisualStyleBackColor = true;
            this.rBtnMedium.CheckedChanged += new System.EventHandler(this.rBtnMedium_CheckedChanged);
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Checked = true;
            this.rBtnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBtnEasy.Location = new System.Drawing.Point(18, 25);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(93, 35);
            this.rBtnEasy.TabIndex = 5;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            this.rBtnEasy.CheckedChanged += new System.EventHandler(this.rBtnEasy_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(210, 144);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(198, 56);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "O&k";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // boxHeight
            // 
            this.boxHeight.Enabled = false;
            this.boxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxHeight.Location = new System.Drawing.Point(327, 18);
            this.boxHeight.Mask = "99";
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(81, 26);
            this.boxHeight.TabIndex = 8;
            this.boxHeight.Text = "10";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Enabled = false;
            this.textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWidth.Location = new System.Drawing.Point(327, 51);
            this.textBoxWidth.Mask = "99";
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(81, 26);
            this.textBoxWidth.TabIndex = 9;
            this.textBoxWidth.Text = "10";
            // 
            // textBoxBombRatio
            // 
            this.textBoxBombRatio.Enabled = false;
            this.textBoxBombRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBombRatio.Location = new System.Drawing.Point(327, 83);
            this.textBoxBombRatio.Mask = "99";
            this.textBoxBombRatio.Name = "textBoxBombRatio";
            this.textBoxBombRatio.Size = new System.Drawing.Size(81, 26);
            this.textBoxBombRatio.TabIndex = 10;
            this.textBoxBombRatio.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(206, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(206, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bomb Ratio, %";
            // 
            // chBoxCommanderMode
            // 
            this.chBoxCommanderMode.AutoSize = true;
            this.chBoxCommanderMode.Enabled = false;
            this.chBoxCommanderMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBoxCommanderMode.Location = new System.Drawing.Point(210, 118);
            this.chBoxCommanderMode.Name = "chBoxCommanderMode";
            this.chBoxCommanderMode.Size = new System.Drawing.Size(159, 24);
            this.chBoxCommanderMode.TabIndex = 14;
            this.chBoxCommanderMode.Text = "Commander mode";
            this.chBoxCommanderMode.UseVisualStyleBackColor = true;
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 210);
            this.Controls.Add(this.chBoxCommanderMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBombRatio);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.boxHeight);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnSpecial;
        private System.Windows.Forms.RadioButton rBtnExpert;
        private System.Windows.Forms.RadioButton rBtnMedium;
        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox boxHeight;
        private System.Windows.Forms.MaskedTextBox textBoxWidth;
        private System.Windows.Forms.MaskedTextBox textBoxBombRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chBoxCommanderMode;
    }
}