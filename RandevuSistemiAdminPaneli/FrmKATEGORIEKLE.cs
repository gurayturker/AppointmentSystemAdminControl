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
    public partial class FrmKATEGORIEKLE : Form,IIslemler
    {
        
        public void temizle()
        {
            txtKATEGORIEKLEKATEGORIAD.Clear();
        }
      
        void KategoriListele()
        {
            List<ENTITYKATEGORI> KategoriListesi = BLLKATEGORI.LISTELE();
            dataGridKATEGORIEKLEKATEGORI.DataSource = KategoriListesi;
        }
        public FrmKATEGORIEKLE()
        {
            InitializeComponent();
        }

        private void FrmKATEGORIEKLE_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnKATEGORIEKLE_Click(object sender, EventArgs e)
        {
            try
            {
              
                    ENTITYKATEGORI ent = new ENTITYKATEGORI();
                    ent.KATEGORIAD = txtKATEGORIEKLEKATEGORIAD.Text;
                    BLLKATEGORI.EKLE(ent);
                    MessageBox.Show("KATEGORİ EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KategoriListele();
                    temizle();
                
               

            }
            catch 
            {

                MessageBox.Show("ZORUNLU ALANLARI LÜTFEN DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           

        }
    }
}
