namespace RandevuSistemiAdminPaneli
{
    partial class FrmIsyerleri
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
            this.gridControlISYERLERI = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlISYERLERI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlISYERLERI
            // 
            this.gridControlISYERLERI.Location = new System.Drawing.Point(4, 1);
            this.gridControlISYERLERI.MainView = this.gridView1;
            this.gridControlISYERLERI.Name = "gridControlISYERLERI";
            this.gridControlISYERLERI.Size = new System.Drawing.Size(1270, 549);
            this.gridControlISYERLERI.TabIndex = 0;
            this.gridControlISYERLERI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.AppearancePrint.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControlISYERLERI;
            this.gridView1.Name = "gridView1";
            // 
            // FrmIsyerleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.gridControlISYERLERI);
            this.Name = "FrmIsyerleri";
            this.Text = "İŞYERLERİ";
            this.Load += new System.EventHandler(this.FrmIsyerleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlISYERLERI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlISYERLERI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}