using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using FACADELAYER;
using BUSINESSLOGICLAYER;
using System.Data.SqlClient;

namespace RandevuSistemiAdminPaneli
{
    public partial class FrmISYERIEKLE : Form,IIslemler
    {
        
        public void temizle()
        {
            txtISYERIADEKLE.Clear();
            txtISYERIYETKILIEKLE.Clear();
            txtISYERIKATEGORIEKLE.Clear();
            rchISYERIADRESEKLE.Clear();
            mskISYERITELEFONEKLE.Clear();
            mskISYERIFAXEKLE.Clear(); 
            txtISYERIEPOSTAEKLE.Clear();
            mskISYERIACILISSAATEKLE.Clear();
            mskKAPANISSAATEKLE.Clear();
            mskCALISMATARIHEKLE.Clear();

        }
       
        void KategoriListele()
        {
            List<ENTITYKATEGORI> KategoriListesi = BLLKATEGORI.LISTELE();
            dataGridISYERIEKLEKATEGORI.DataSource = KategoriListesi;
        }
        void YetkiliListele()
        {
            List<ENTITYISYERIYETKILI> YetkiliListesi = BLLISYERIYETKILI.LISTELE();
            dataGridISYERIEKLEYETKILI.DataSource = YetkiliListesi;
        }

        public FrmISYERIEKLE()
        {
            InitializeComponent();
        }

        private void FrmISYERIEKLE_Load(object sender, EventArgs e)
        {
            KategoriListele();
            YetkiliListele();

        }
        

        private void btnISYERIKAYDET_Click(object sender, EventArgs e)
        {
            try
            {
                ENTITYISYERI ent = new ENTITYISYERI();
                ent.ISYERIAD = txtISYERIADEKLE.Text;
                ent.ISYERIYETKILIID= Convert.ToInt32(txtISYERIYETKILIEKLE.Text);
                ent.ISYERIKATEGORI = Convert.ToInt32(txtISYERIKATEGORIEKLE.Text);
                ent.ISYERIADRES = rchISYERIADRESEKLE.Text;
                ent.TELEFON = mskISYERITELEFONEKLE.Text;
                ent.FAX = mskISYERIFAXEKLE.Text;
                ent.EPOSTA = txtISYERIEPOSTAEKLE.Text;
                ent.ISYERIACILISSAATI = mskISYERIACILISSAATEKLE.Text;
                ent.ISYERIKAPANISSAATI = mskKAPANISSAATEKLE.Text;
                ent.ISYERICALISMATARIH = mskCALISMATARIHEKLE.Text;
                BLLISYERI.EKLE(ent);
                MessageBox.Show("İŞYERİ EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();


            }
            catch 
            {
                MessageBox.Show("ZORUNLU ALANLARDA EKSİĞİNİZ OLMADIĞINIZA VE GEÇERLİ BİR YETKİLİ GİRDİĞİNİZE EMİN OLUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
          
        }
    }
}
