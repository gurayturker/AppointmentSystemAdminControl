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
    public partial class FrmISYERIILETISIM : Form
    {
        
        void IletisimBilgileriListele()
        {
            List<ENTITYILETISIM> İletisim = BLLISYERI.ILETISIMBILGILERILISTELE();
            gridControlISYERIILETISIM.DataSource = İletisim;
        }
        public FrmISYERIILETISIM()
        {
            InitializeComponent();
        }

        private void FrmILETISIMBILGILERI_Load(object sender, EventArgs e)
        {
            IletisimBilgileriListele();
        }
    }
}
