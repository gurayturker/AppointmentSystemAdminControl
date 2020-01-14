namespace RandevuSistemiAdminPaneli
{
    partial class FrmRANDEVULAR
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
            this.gridControlRANDEVULAR = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRANDEVULAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRANDEVULAR
            // 
            this.gridControlRANDEVULAR.Location = new System.Drawing.Point(3, 2);
            this.gridControlRANDEVULAR.MainView = this.gridView1;
            this.gridControlRANDEVULAR.Name = "gridControlRANDEVULAR";
            this.gridControlRANDEVULAR.Size = new System.Drawing.Size(1269, 546);
            this.gridControlRANDEVULAR.TabIndex = 0;
            this.gridControlRANDEVULAR.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlRANDEVULAR;
            this.gridView1.Name = "gridView1";
            // 
            // FrmRANDEVULAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.gridControlRANDEVULAR);
            this.Name = "FrmRANDEVULAR";
            this.Text = "RANDEVULAR";
            this.Load += new System.EventHandler(this.FrmRANDEVULAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRANDEVULAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlRANDEVULAR;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}