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
    public partial class FrmYETKILIILETISIM : Form
    {
        void ILETISIMBILGILERILISTELE()
        {
            List<ENTITYILETISIM> IletisimBilgileri = BLLISYERIYETKILI.ILETISIMBILGILERILISTELE();
            gridControlYETKILIILETISIM.DataSource = IletisimBilgileri;
        }
        public FrmYETKILIILETISIM()
        {
            InitializeComponent();
        }

        private void FrmYETKILIILETISIM_Load(object sender, EventArgs e)
        {
            ILETISIMBILGILERILISTELE();
        }
    }
}
