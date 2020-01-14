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

namespace RandevuSistemiAdminPaneli
{
    public partial class FrmKATEGORIGUNCELLE : Form,IIslemler
    {
        public void temizle()
        {
            txtKATEGORIGUNCELLEID.Clear();
           txtKATEGORIEKLEKATEGORIAD.Clear();

        }
        
        void KategoriListele()
        {
            List<ENTITYKATEGORI> KategoriListesi = BLLKATEGORI.LISTELE();
            dataGridKATEGORIGUNCELLEKATEGORI.DataSource = KategoriListesi;
        }
        public FrmKATEGORIGUNCELLE()
        {
            InitializeComponent();
        }

        private void FrmKATEGORIGUNCELLE_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnKATEGORIGUNCELLE_Click(object sender, EventArgs e)
        {
            try
            {
                ENTITYKATEGORI ent = new ENTITYKATEGORI();
                ent.KATEGORIID = Convert.ToInt32(txtKATEGORIGUNCELLEID.Text);
                ent.KATEGORIAD = txtKATEGORIEKLEKATEGORIAD.Text;
                BLLKATEGORI.GUNCELLE(ent);
                MessageBox.Show("KATEGORİ GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KategoriListele();
                temizle();
            }
            catch 
            {

                MessageBox.Show("ZORUNLU ALANLARI LÜTFEN DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void dataGridKATEGORIGUNCELLEKATEGORI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridKATEGORIGUNCELLEKATEGORI.SelectedCells[0].RowIndex;
            txtKATEGORIGUNCELLEID.Text = dataGridKATEGORIGUNCELLEKATEGORI.Rows[secilen].Cells[0].Value.ToString();
            txtKATEGORIEKLEKATEGORIAD.Text = dataGridKATEGORIGUNCELLEKATEGORI.Rows[secilen].Cells[1].Value.ToString();
            KategoriListele();
        }
    }
}
