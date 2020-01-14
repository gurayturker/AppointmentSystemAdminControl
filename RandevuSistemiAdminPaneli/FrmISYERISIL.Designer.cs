namespace RandevuSistemiAdminPaneli
{
    partial class FrmISYERISIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmISYERISIL));
            this.dataGridISYERISILISYERI = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtISYERISILID = new System.Windows.Forms.TextBox();
            this.btnISYERISIL = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlISYERISIL = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridISYERISILISYERI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlISYERISIL)).BeginInit();
            this.groupControlISYERISIL.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridISYERISILISYERI
            // 
            this.dataGridISYERISILISYERI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridISYERISILISYERI.Location = new System.Drawing.Point(574, 6);
            this.dataGridISYERISILISYERI.Name = "dataGridISYERISILISYERI";
            this.dataGridISYERISILISYERI.RowHeadersWidth = 51;
            this.dataGridISYERISILISYERI.RowTemplate.Height = 24;
            this.dataGridISYERISILISYERI.Size = new System.Drawing.Size(696, 540);
            this.dataGridISYERISILISYERI.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İŞYERİ ID:";
            // 
            // txtISYERISILID
            // 
            this.txtISYERISILID.Location = new System.Drawing.Point(197, 73);
            this.txtISYERISILID.Name = "txtISYERISILID";
            this.txtISYERISILID.Size = new System.Drawing.Size(202, 23);
            this.txtISYERISILID.TabIndex = 2;
            // 
            // btnISYERISIL
            // 
            this.btnISYERISIL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnISYERISIL.ImageOptions.Image")));
            this.btnISYERISIL.Location = new System.Drawing.Point(197, 127);
            this.btnISYERISIL.Name = "btnISYERISIL";
            this.btnISYERISIL.Size = new System.Drawing.Size(202, 48);
            this.btnISYERISIL.TabIndex = 3;
            this.btnISYERISIL.Text = "SİL";
            this.btnISYERISIL.Click += new System.EventHandler(this.btnISYERISIL_Click);
            // 
            // groupControlISYERISIL
            // 
            this.groupControlISYERISIL.Controls.Add(this.btnISYERISIL);
            this.groupControlISYERISIL.Controls.Add(this.txtISYERISILID);
            this.groupControlISYERISIL.Controls.Add(this.labelControl1);
            this.groupControlISYERISIL.Location = new System.Drawing.Point(7, 6);
            this.groupControlISYERISIL.Name = "groupControlISYERISIL";
            this.groupControlISYERISIL.Size = new System.Drawing.Size(552, 540);
            this.groupControlISYERISIL.TabIndex = 2;
            this.groupControlISYERISIL.Text = "İŞYERİ SİL";
            // 
            // FrmISYERISIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.groupControlISYERISIL);
            this.Controls.Add(this.dataGridISYERISILISYERI);
            this.Name = "FrmISYERISIL";
            this.Text = "İŞYERİ SİL";
            this.Load += new System.EventHandler(this.FrmISYERISIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridISYERISILISYERI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlISYERISIL)).EndInit();
            this.groupControlISYERISIL.ResumeLayout(false);
            this.groupControlISYERISIL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridISYERISILISYERI;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtISYERISILID;
        private DevExpress.XtraEditors.SimpleButton btnISYERISIL;
        private DevExpress.XtraEditors.GroupControl groupControlISYERISIL;
    }
}