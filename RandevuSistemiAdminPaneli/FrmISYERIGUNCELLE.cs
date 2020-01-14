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
    public partial class FrmISYERIGUNCELLE : Form,IIslemler
    {
       
       public void temizle()
        {
            txtISYERIGUNCELLEID.Clear();
            txtISYERIADGUNCELLE.Clear();
            txtISYERIYETKILIGUNCELLE.Clear();
            txtISYERIKATEGORIGUNCELLE.Clear();
            rchISYERIADRESGUNCELLE.Clear();
            mskISYERITELEFONGUNCELLE.Clear();
             mskISYERIFAXGUNCELLE.Clear();
             txtISYERIEPOSTAGUNCELLE.Clear();
             mskISYERIACILISSAATGUNCELLE.Clear();
             mskKAPANISSAATGUNCELLE.Clear();
             mskCALISMATARIHGUNCELLE.Clear();

        }
        void IsyeriListele()
        {
            List<ENTITYISYERI> IsyeriListesi = BLLISYERI.LISTELE();
            dataGridISYERIGUNCELLEISYERILISTE.DataSource = IsyeriListesi;
        }
        public FrmISYERIGUNCELLE()
        {
            InitializeComponent();
        }

        private void FrmISYERIGUNCELLE_Load(object sender, EventArgs e)
        {
            IsyeriListele();

        }

        private void btnISYERIGUNCELLE_Click(object sender, EventArgs e)
        {
            try
            {
                    ENTITYISYERI ent = new ENTITYISYERI();
                    ent.ISYERIID = Convert.ToInt32(txtISYERIGUNCELLEID.Text);
                    ent.ISYERIAD = txtISYERIADGUNCELLE.Text;
                    ent.ISYERIYETKILIID= Convert.ToInt32(txtISYERIYETKILIGUNCELLE.Text);
                    ent.ISYERIKATEGORI = Convert.ToInt32(txtISYERIKATEGORIGUNCELLE.Text);
                    ent.ISYERIADRES = rchISYERIADRESGUNCELLE.Text;
                    ent.TELEFON = mskISYERITELEFONGUNCELLE.Text;
                    ent.FAX = mskISYERIFAXGUNCELLE.Text;
                    ent.EPOSTA = txtISYERIEPOSTAGUNCELLE.Text;
                    ent.ISYERIACILISSAATI = mskISYERIACILISSAATGUNCELLE.Text;
                    ent.ISYERIKAPANISSAATI = mskKAPANISSAATGUNCELLE.Text;
                    ent.ISYERICALISMATARIH = mskCALISMATARIHGUNCELLE.Text;
                    BLLISYERI.GUNCELLE(ent);
                    MessageBox.Show("İŞYERİ GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsyeriListele();
                    temizle();
                
                

            }
            catch 
            {

                MessageBox.Show("ZORUNLU ALANLARI LÜTFEN DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridISYERIGUNCELLEISYERILISTE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridISYERIGUNCELLEISYERILISTE.SelectedCells[0].RowIndex;
            txtISYERIGUNCELLEID.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[0].Value.ToString();
            txtISYERIADGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[10].Value.ToString();
            txtISYERIYETKILIGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[1].Value.ToString();
            txtISYERIKATEGORIGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[2].Value.ToString();
            rchISYERIADRESGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[3].Value.ToString();
            mskISYERITELEFONGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[7].Value.ToString();
            mskISYERIFAXGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[8].Value.ToString();
            txtISYERIEPOSTAGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[9].Value.ToString();
            mskISYERIACILISSAATGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[4].Value.ToString();
            mskKAPANISSAATGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[5].Value.ToString();
            mskCALISMATARIHGUNCELLE.Text = dataGridISYERIGUNCELLEISYERILISTE.Rows[secilen].Cells[6].Value.ToString();
            
           
        }
    }
}
