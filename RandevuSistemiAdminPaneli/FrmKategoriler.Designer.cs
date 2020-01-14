namespace RandevuSistemiAdminPaneli
{
    partial class FrmKategoriler
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
            this.gridControlKATEGORILER = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKATEGORILER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKATEGORILER
            // 
            this.gridControlKATEGORILER.Location = new System.Drawing.Point(0, 3);
            this.gridControlKATEGORILER.MainView = this.gridView1;
            this.gridControlKATEGORILER.Name = "gridControlKATEGORILER";
            this.gridControlKATEGORILER.Size = new System.Drawing.Size(1275, 547);
            this.gridControlKATEGORILER.TabIndex = 0;
            this.gridControlKATEGORILER.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControlKATEGORILER;
            this.gridView1.Name = "gridView1";
            // 
            // FrmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.gridControlKATEGORILER);
            this.Name = "FrmKategoriler";
            this.Text = "KATEGORİLER";
            this.Load += new System.EventHandler(this.FrmKategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKATEGORILER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKATEGORILER;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}