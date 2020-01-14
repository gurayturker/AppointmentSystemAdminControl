namespace RandevuSistemiAdminPaneli
{
    partial class FrmGirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKULLANICIADGIRIS = new DevExpress.XtraEditors.TextEdit();
            this.txtSIFREGIRIS = new DevExpress.XtraEditors.TextEdit();
            this.btnGIRISYAP = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtKULLANICIADGIRIS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSIFREGIRIS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " KULLANICI AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE:";
            // 
            // txtKULLANICIADGIRIS
            // 
            this.txtKULLANICIADGIRIS.Location = new System.Drawing.Point(205, 118);
            this.txtKULLANICIADGIRIS.Name = "txtKULLANICIADGIRIS";
            this.txtKULLANICIADGIRIS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKULLANICIADGIRIS.Properties.Appearance.Options.UseFont = true;
            this.txtKULLANICIADGIRIS.Size = new System.Drawing.Size(209, 30);
            this.txtKULLANICIADGIRIS.TabIndex = 2;
            // 
            // txtSIFREGIRIS
            // 
            this.txtSIFREGIRIS.Location = new System.Drawing.Point(205, 168);
            this.txtSIFREGIRIS.Name = "txtSIFREGIRIS";
            this.txtSIFREGIRIS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSIFREGIRIS.Properties.Appearance.Options.UseFont = true;
            this.txtSIFREGIRIS.Properties.UseSystemPasswordChar = true;
            this.txtSIFREGIRIS.Size = new System.Drawing.Size(209, 30);
            this.txtSIFREGIRIS.TabIndex = 3;
            // 
            // btnGIRISYAP
            // 
            this.btnGIRISYAP.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGIRISYAP.Appearance.Options.UseBorderColor = true;
            this.btnGIRISYAP.Appearance.Options.UseFont = true;
            this.btnGIRISYAP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGIRISYAP.ImageOptions.Image")));
            this.btnGIRISYAP.Location = new System.Drawing.Point(218, 226);
            this.btnGIRISYAP.Name = "btnGIRISYAP";
            this.btnGIRISYAP.Size = new System.Drawing.Size(165, 51);
            this.btnGIRISYAP.TabIndex = 5;
            this.btnGIRISYAP.Text = "GİRİŞ YAP";
            this.btnGIRISYAP.Click += new System.EventHandler(this.btnGIRISYAP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(203, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "ADMİN GİRİŞ";
            // 
            // FrmGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 337);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGIRISYAP);
            this.Controls.Add(this.txtSIFREGIRIS);
            this.Controls.Add(this.txtKULLANICIADGIRIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ YAPINIZ";
            ((System.ComponentModel.ISupportInitialize)(this.txtKULLANICIADGIRIS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSIFREGIRIS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKULLANICIADGIRIS;
        private DevExpress.XtraEditors.TextEdit txtSIFREGIRIS;
        private DevExpress.XtraEditors.SimpleButton btnGIRISYAP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}