namespace RandevuSistemiAdminPaneli
{
    partial class FrmYETKILISIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYETKILISIL));
            this.groupControlYETKILISIL = new DevExpress.XtraEditors.GroupControl();
            this.btnYETKILISIL = new DevExpress.XtraEditors.SimpleButton();
            this.txtYETKILISILID = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridYETKILISILYETKILI = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlYETKILISIL)).BeginInit();
            this.groupControlYETKILISIL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYETKILISILYETKILI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlYETKILISIL
            // 
            this.groupControlYETKILISIL.Controls.Add(this.btnYETKILISIL);
            this.groupControlYETKILISIL.Controls.Add(this.txtYETKILISILID);
            this.groupControlYETKILISIL.Controls.Add(this.labelControl1);
            this.groupControlYETKILISIL.Location = new System.Drawing.Point(7, 6);
            this.groupControlYETKILISIL.Name = "groupControlYETKILISIL";
            this.groupControlYETKILISIL.Size = new System.Drawing.Size(552, 540);
            this.groupControlYETKILISIL.TabIndex = 4;
            this.groupControlYETKILISIL.Text = "YETKİLİ SİL";
            // 
            // btnYETKILISIL
            // 
            this.btnYETKILISIL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYETKILISIL.ImageOptions.Image")));
            this.btnYETKILISIL.Location = new System.Drawing.Point(197, 127);
            this.btnYETKILISIL.Name = "btnYETKILISIL";
            this.btnYETKILISIL.Size = new System.Drawing.Size(202, 48);
            this.btnYETKILISIL.TabIndex = 3;
            this.btnYETKILISIL.Text = "SİL";
            this.btnYETKILISIL.Click += new System.EventHandler(this.btnYETKILISIL_Click);
            // 
            // txtYETKILISILID
            // 
            this.txtYETKILISILID.Location = new System.Drawing.Point(197, 73);
            this.txtYETKILISILID.Name = "txtYETKILISILID";
            this.txtYETKILISILID.Size = new System.Drawing.Size(202, 23);
            this.txtYETKILISILID.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "YETKİLİ ID:";
            // 
            // dataGridYETKILISILYETKILI
            // 
            this.dataGridYETKILISILYETKILI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridYETKILISILYETKILI.Location = new System.Drawing.Point(574, 6);
            this.dataGridYETKILISILYETKILI.Name = "dataGridYETKILISILYETKILI";
            this.dataGridYETKILISILYETKILI.RowHeadersWidth = 51;
            this.dataGridYETKILISILYETKILI.RowTemplate.Height = 24;
            this.dataGridYETKILISILYETKILI.Size = new System.Drawing.Size(696, 540);
            this.dataGridYETKILISILYETKILI.TabIndex = 5;
            // 
            // FrmYETKILISIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.groupControlYETKILISIL);
            this.Controls.Add(this.dataGridYETKILISILYETKILI);
            this.Name = "FrmYETKILISIL";
            this.Text = "YETKİLİ SİL";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlYETKILISIL)).EndInit();
            this.groupControlYETKILISIL.ResumeLayout(false);
            this.groupControlYETKILISIL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridYETKILISILYETKILI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlYETKILISIL;
        private DevExpress.XtraEditors.SimpleButton btnYETKILISIL;
        private System.Windows.Forms.TextBox txtYETKILISILID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridYETKILISILYETKILI;
    }
}