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
    public partial class FrmISYERISIL : Form
    {
        void IsyeriListele()
        {
            List<ENTITYISYERI> IsyeriListesi = BLLISYERI.LISTELE();
            dataGridISYERISILISYERI.DataSource = IsyeriListesi;
        }
        public FrmISYERISIL()
        {

            InitializeComponent();
        }

        private void FrmISYERISIL_Load(object sender, EventArgs e)
        {
            IsyeriListele();
        }

        private void btnISYERISIL_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("İlişkili Tablolar üzerinde çalıştığınız için bu veriyi silemiyoruz.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }
    }
}
