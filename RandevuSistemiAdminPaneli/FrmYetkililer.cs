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
    public partial class FrmYetkililer : Form
    {
        void YetkiliListele()
        {
            List<ENTITYISYERIYETKILI> YetkiliListesi = BLLISYERIYETKILI.LISTELE();
            gridControlYETKILILER.DataSource = YetkiliListesi;
        }

        public FrmYetkililer()
        {
            InitializeComponent();
        }

        private void FrmYetkililer_Load(object sender, EventArgs e)
        {
            YetkiliListele();
        }
    }
}
