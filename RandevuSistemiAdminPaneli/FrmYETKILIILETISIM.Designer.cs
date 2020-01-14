namespace RandevuSistemiAdminPaneli
{
    partial class FrmYETKILIILETISIM
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
            this.gridControlYETKILIILETISIM = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYETKILIILETISIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlYETKILIILETISIM
            // 
            this.gridControlYETKILIILETISIM.Location = new System.Drawing.Point(4, 2);
            this.gridControlYETKILIILETISIM.MainView = this.gridView1;
            this.gridControlYETKILIILETISIM.Name = "gridControlYETKILIILETISIM";
            this.gridControlYETKILIILETISIM.Size = new System.Drawing.Size(1271, 548);
            this.gridControlYETKILIILETISIM.TabIndex = 0;
            this.gridControlYETKILIILETISIM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlYETKILIILETISIM;
            this.gridView1.Name = "gridView1";
            // 
            // FrmYETKILIILETISIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.gridControlYETKILIILETISIM);
            this.Name = "FrmYETKILIILETISIM";
            this.Text = "YETKİLİ İLETİŞİM";
            this.Load += new System.EventHandler(this.FrmYETKILIILETISIM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYETKILIILETISIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlYETKILIILETISIM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}