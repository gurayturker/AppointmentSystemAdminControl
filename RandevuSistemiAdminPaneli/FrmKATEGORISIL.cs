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
    public partial class FrmKATEGORISIL : Form
    {
        void KategoriListele()
        {
            List<ENTITYKATEGORI> KategoriListesi = BLLKATEGORI.LISTELE();
            dataGridKATEGORISILKATEGORI.DataSource = KategoriListesi;
        }
        public FrmKATEGORISIL()
        {
            InitializeComponent();
        }

        private void FrmKATEGORISIL_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnKATEGORISIL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlişkili Tablolar üzerinde çalıştığınız için bu veriyi silemiyoruz.Lütfen silmek istediğiniz satırı güncelleme yaparak durumunu pasif hale getirin", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
