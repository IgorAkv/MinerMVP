namespace Akimov.MinerMVP.Views {
    partial class SettingForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnSpecial = new System.Windows.Forms.RadioButton();
            this.rBtnExpert = new System.Windows.Forms.RadioButton();
            this.rBtnMedium = new System.Windows.Forms.RadioButton();
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.MaskedTextBox();
            this.txtColumns = new System.Windows.Forms.MaskedTextBox();
            this.txtBombRatio = new System.Windows.Forms.MaskedTextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelBombRatio = new System.Windows.Forms.Label();
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
            this.btnOk.Location = new System.Drawing.Point(210, 148);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(198, 56);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "O&k";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtRows
            // 
            this.txtRows.Enabled = false;
            this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRows.Location = new System.Drawing.Point(327, 18);
            this.txtRows.Mask = "99";
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(81, 26);
            this.txtRows.TabIndex = 8;
            this.txtRows.Text = "10";
            // 
            // txtColumns
            // 
            this.txtColumns.Enabled = false;
            this.txtColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtColumns.Location = new System.Drawing.Point(327, 51);
            this.txtColumns.Mask = "99";
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(81, 26);
            this.txtColumns.TabIndex = 9;
            this.txtColumns.Text = "10";
            // 
            // txtBombRatio
            // 
            this.txtBombRatio.Enabled = false;
            this.txtBombRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBombRatio.Location = new System.Drawing.Point(327, 83);
            this.txtBombRatio.Mask = "99";
            this.txtBombRatio.Name = "txtBombRatio";
            this.txtBombRatio.Size = new System.Drawing.Size(81, 26);
            this.txtBombRatio.TabIndex = 10;
            this.txtBombRatio.Text = "5";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRows.Location = new System.Drawing.Point(206, 24);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(49, 20);
            this.labelRows.TabIndex = 11;
            this.labelRows.Text = "Rows";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumns.Location = new System.Drawing.Point(206, 57);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(71, 20);
            this.labelColumns.TabIndex = 12;
            this.labelColumns.Text = "Columns";
            // 
            // labelBombRatio
            // 
            this.labelBombRatio.AutoSize = true;
            this.labelBombRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBombRatio.Location = new System.Drawing.Point(206, 89);
            this.labelBombRatio.Name = "labelBombRatio";
            this.labelBombRatio.Size = new System.Drawing.Size(115, 20);
            this.labelBombRatio.TabIndex = 13;
            this.labelBombRatio.Text = "Bomb Ratio, %";
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
            this.Controls.Add(this.labelBombRatio);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.txtBombRatio);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtRows);
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
        private System.Windows.Forms.MaskedTextBox txtRows;
        private System.Windows.Forms.MaskedTextBox txtColumns;
        private System.Windows.Forms.MaskedTextBox txtBombRatio;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelBombRatio;
        private System.Windows.Forms.CheckBox chBoxCommanderMode;
    }
}