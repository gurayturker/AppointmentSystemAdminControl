namespace RandevuSistemiAdminPaneli
{
    partial class FrmMAILGONDER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMAILGONDER));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKIME = new System.Windows.Forms.TextBox();
            this.txtBASLIK = new System.Windows.Forms.TextBox();
            this.rchMESAJ = new System.Windows.Forms.RichTextBox();
            this.btnMAILYOLLA = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BAŞLIK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "MESAJ:";
            // 
            // txtKIME
            // 
            this.txtKIME.Location = new System.Drawing.Point(148, 111);
            this.txtKIME.Name = "txtKIME";
            this.txtKIME.Size = new System.Drawing.Size(406, 22);
            this.txtKIME.TabIndex = 4;
            // 
            // txtBASLIK
            // 
            this.txtBASLIK.Location = new System.Drawing.Point(148, 152);
            this.txtBASLIK.Name = "txtBASLIK";
            this.txtBASLIK.Size = new System.Drawing.Size(406, 22);
            this.txtBASLIK.TabIndex = 6;
            // 
            // rchMESAJ
            // 
            this.rchMESAJ.Location = new System.Drawing.Point(148, 192);
            this.rchMESAJ.Name = "rchMESAJ";
            this.rchMESAJ.Size = new System.Drawing.Size(406, 280);
            this.rchMESAJ.TabIndex = 7;
            this.rchMESAJ.Text = "";
            // 
            // btnMAILYOLLA
            // 
            this.btnMAILYOLLA.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMAILYOLLA.Appearance.Options.UseFont = true;
            this.btnMAILYOLLA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMAILYOLLA.ImageOptions.Image")));
            this.btnMAILYOLLA.Location = new System.Drawing.Point(251, 498);
            this.btnMAILYOLLA.Name = "btnMAILYOLLA";
            this.btnMAILYOLLA.Size = new System.Drawing.Size(185, 60);
            this.btnMAILYOLLA.TabIndex = 8;
            this.btnMAILYOLLA.Text = "GÖNDER";
            this.btnMAILYOLLA.Click += new System.EventHandler(this.btnMAILYOLLA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 92);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMAILGONDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(658, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMAILYOLLA);
            this.Controls.Add(this.rchMESAJ);
            this.Controls.Add(this.txtBASLIK);
            this.Controls.Add(this.txtKIME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmMAILGONDER";
            this.Text = "YENİ MESAJ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKIME;
        private System.Windows.Forms.TextBox txtBASLIK;
        private System.Windows.Forms.RichTextBox rchMESAJ;
        private DevExpress.XtraEditors.SimpleButton btnMAILYOLLA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}