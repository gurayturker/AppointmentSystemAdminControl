namespace RandevuSistemiAdminPaneli
{
    partial class FrmISYERIILETISIM
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
            this.gridControlISYERIILETISIM = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlISYERIILETISIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlISYERIILETISIM
            // 
            this.gridControlISYERIILETISIM.Location = new System.Drawing.Point(4, 5);
            this.gridControlISYERIILETISIM.MainView = this.gridView1;
            this.gridControlISYERIILETISIM.Name = "gridControlISYERIILETISIM";
            this.gridControlISYERIILETISIM.Size = new System.Drawing.Size(1270, 547);
            this.gridControlISYERIILETISIM.TabIndex = 0;
            this.gridControlISYERIILETISIM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlISYERIILETISIM;
            this.gridView1.Name = "gridView1";
            // 
            // FrmISYERIILETISIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.gridControlISYERIILETISIM);
            this.Name = "FrmISYERIILETISIM";
            this.Text = "İŞYERİ İLETİŞİM";
            this.Load += new System.EventHandler(this.FrmILETISIMBILGILERI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlISYERIILETISIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlISYERIILETISIM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}