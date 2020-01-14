namespace RandevuSistemiAdminPaneli
{
    partial class FrmYetkililer
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
            this.gridControlYETKILILER = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYETKILILER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlYETKILILER
            // 
            this.gridControlYETKILILER.Location = new System.Drawing.Point(3, 3);
            this.gridControlYETKILILER.MainView = this.gridView1;
            this.gridControlYETKILILER.Name = "gridControlYETKILILER";
            this.gridControlYETKILILER.Size = new System.Drawing.Size(1270, 547);
            this.gridControlYETKILILER.TabIndex = 0;
            this.gridControlYETKILILER.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.AppearancePrint.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControlYETKILILER;
            this.gridView1.Name = "gridView1";
            // 
            // FrmYetkililer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 553);
            this.Controls.Add(this.gridControlYETKILILER);
            this.Name = "FrmYetkililer";
            this.Text = "YETKİLİLER";
            this.Load += new System.EventHandler(this.FrmYetkililer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlYETKILILER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlYETKILILER;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}