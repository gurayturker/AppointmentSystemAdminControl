namespace RandevuSistemiAdminPaneli
{
    partial class FrmKATEGORISIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKATEGORISIL));
            this.groupControlKATEGORISIL = new DevExpress.XtraEditors.GroupControl();
            this.btnKATEGORISIL = new DevExpress.XtraEditors.SimpleButton();
            this.txtKATEGORISILID = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridKATEGORISILKATEGORI = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlKATEGORISIL)).BeginInit();
            this.groupControlKATEGORISIL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKATEGORISILKATEGORI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlKATEGORISIL
            // 
            this.groupControlKATEGORISIL.Controls.Add(this.btnKATEGORISIL);
            this.groupControlKATEGORISIL.Controls.Add(this.txtKATEGORISILID);
            this.groupControlKATEGORISIL.Controls.Add(this.labelControl1);
            this.groupControlKATEGORISIL.Location = new System.Drawing.Point(7, 6);
            this.groupControlKATEGORISIL.Name = "groupControlKATEGORISIL";
            this.groupControlKATEGORISIL.Size = new System.Drawing.Size(542, 545);
            this.groupControlKATEGORISIL.TabIndex = 6;
            this.groupControlKATEGORISIL.Text = "KATEGORİ SİL";
            // 
            // btnKATEGORISIL
            // 
            this.btnKATEGORISIL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKATEGORISIL.ImageOptions.Image")));
            this.btnKATEGORISIL.Location = new System.Drawing.Point(197, 127);
            this.btnKATEGORISIL.Name = "btnKATEGORISIL";
            this.btnKATEGORISIL.Size = new System.Drawing.Size(202, 48);
            this.btnKATEGORISIL.TabIndex = 3;
            this.btnKATEGORISIL.Text = "SİL";
            this.btnKATEGORISIL.Click += new System.EventHandler(this.btnKATEGORISIL_Click);
            // 
            // txtKATEGORISILID
            // 
            this.txtKATEGORISILID.Location = new System.Drawing.Point(197, 73);
            this.txtKATEGORISILID.Name = "txtKATEGORISILID";
            this.txtKATEGORISILID.Size = new System.Drawing.Size(202, 23);
            this.txtKATEGORISILID.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "KATEGORİ ID:";
            // 
            // dataGridKATEGORISILKATEGORI
            // 
            this.dataGridKATEGORISILKATEGORI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKATEGORISILKATEGORI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKATEGORISILKATEGORI.Location = new System.Drawing.Point(574, 6);
            this.dataGridKATEGORISILKATEGORI.Name = "dataGridKATEGORISILKATEGORI";
            this.dataGridKATEGORISILKATEGORI.RowHeadersWidth = 51;
            this.dataGridKATEGORISILKATEGORI.RowTemplate.Height = 24;
            this.dataGridKATEGORISILKATEGORI.Size = new System.Drawing.Size(696, 540);
            this.dataGridKATEGORISILKATEGORI.TabIndex = 7;
            // 
            // FrmKATEGORISIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.groupControlKATEGORISIL);
            this.Controls.Add(this.dataGridKATEGORISILKATEGORI);
            this.Name = "FrmKATEGORISIL";
            this.Text = "KATEGORİ SİL";
            this.Load += new System.EventHandler(this.FrmKATEGORISIL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlKATEGORISIL)).EndInit();
            this.groupControlKATEGORISIL.ResumeLayout(false);
            this.groupControlKATEGORISIL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKATEGORISILKATEGORI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlKATEGORISIL;
        private DevExpress.XtraEditors.SimpleButton btnKATEGORISIL;
        private System.Windows.Forms.TextBox txtKATEGORISILID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridKATEGORISILKATEGORI;
    }
}