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


namespace RandevuSistemiAdminPaneli
{
    public partial class FrmKategoriler : Form
    {
      
        void KategoriListele()
        {
            List<ENTITYKATEGORI> KategoriListesi = BLLKATEGORI.LISTELE();
            gridControlKATEGORILER.DataSource = KategoriListesi;
        }
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }
    }
}
