using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FACADELAYER;
using ENTITYLAYER;
using BUSINESSLOGICLAYER;
using System.Data.SqlClient;


namespace RandevuSistemiAdminPaneli
{
    public partial class FrmYETKILIGUNCELLE : Form,IIslemler
    {
       
        public void temizle()
        {
            
            txtKULLANICIIDGUNCELLE.Clear();
            txtYETKILIKULLANICIADIGUNCELLE.Clear();
            txtYETKILISIFREGUNCELLE.Clear();
            txtYETKILIADGUNCELLE.Clear();
            txtYETKILISOYADGUNCELLE.Clear();
            mskYETKILITCGUNCELLE.Clear();
            mskYETKILIDOGUMGUNCELLE.Clear();
            rchYETKILIADRESGUNCELLE.Clear();
             mskYETKILITELEFONGUNCELLE.Clear();
           txtYETKILIEPOSTAGUNCELLE.Clear();
        }
        void YETKILILISTELE()
        {
            List<ENTITYISYERIYETKILI> YetkiliListesi = BLLISYERIYETKILI.LISTELE();
            dataYETKILIGUNCELLEYETKILI.DataSource = YetkiliListesi;
            
        }
        public FrmYETKILIGUNCELLE()
        {
            InitializeComponent();
        }

        private void FrmYETKILIGUNCELLE_Load(object sender, EventArgs e)
        {
            YETKILILISTELE();
        }

        private void btnYETKILIGUNCELLE_Click(object sender, EventArgs e)
        {
            try
            {
               

                    ENTITYISYERIYETKILI ent = new ENTITYISYERIYETKILI();
                    ent.YETKILIID = Convert.ToInt32(txtKULLANICIIDGUNCELLE.Text);
                    ent.KULLANICIAD = txtYETKILIKULLANICIADIGUNCELLE.Text;
                    ent.SIFRE = txtYETKILISIFREGUNCELLE.Text;
                    ent.AD = txtYETKILIADGUNCELLE.Text;
                    ent.SOYAD = txtYETKILISOYADGUNCELLE.Text;
                    ent.TCKIMLIK = mskYETKILITCGUNCELLE.Text;
                    ent.DOGUMTARIHI = mskYETKILIDOGUMGUNCELLE.Text;
                    ent.ADRES = rchYETKILIADRESGUNCELLE.Text;
                    ent.TELEFON = mskYETKILITELEFONGUNCELLE.Text;
                    ent.EPOSTA = txtYETKILIEPOSTAGUNCELLE.Text;
                    BLLISYERIYETKILI.GUNCELLE(ent);
                    MessageBox.Show("YETKİLİ GUNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                    YETKILILISTELE();
                
            }
            catch 
            {

                MessageBox.Show("ZORUNLU ALANLARI LÜTFEN DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataYETKILIGUNCELLEYETKILI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataYETKILIGUNCELLEYETKILI.SelectedCells[0].RowIndex;
            txtKULLANICIIDGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[0].Value.ToString();
            txtYETKILIKULLANICIADIGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[1].Value.ToString();
            txtYETKILISIFREGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[2].Value.ToString();
            txtYETKILIADGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[11].Value.ToString();
            txtYETKILISOYADGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[4].Value.ToString();
            mskYETKILITCGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[3].Value.ToString();
            mskYETKILIDOGUMGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[5].Value.ToString();
            rchYETKILIADRESGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[6].Value.ToString();
            mskYETKILITELEFONGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[7].Value.ToString();
            txtYETKILIEPOSTAGUNCELLE.Text = dataYETKILIGUNCELLEYETKILI.Rows[secilen].Cells[9].Value.ToString();
        }
    }
}
