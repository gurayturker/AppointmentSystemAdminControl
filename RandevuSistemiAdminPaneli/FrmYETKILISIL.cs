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
    public partial class FrmYETKILISIL : Form
    {
        void YETKILILISTELE()
        {
            List<ENTITYISYERIYETKILI> YetkiliListesi = BLLISYERIYETKILI.LISTELE();
            dataGridYETKILISILYETKILI.DataSource = YetkiliListesi;
        }
        public FrmYETKILISIL()
        {
            InitializeComponent();
             YETKILILISTELE();
        }

        private void btnYETKILISIL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlişkili Tablolar üzerinde çalıştığınız için bu veriyi silemiyoruz.Lütfen silmek istediğiniz satırı güncelleme yaparak durumunu pasif hale getirin", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
