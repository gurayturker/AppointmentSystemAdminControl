using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemiAdminPaneli
{
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }
        FrmADMINPANELI frmadminpaneli=new FrmADMINPANELI();
       
        private void btnGIRISYAP_Click(object sender, EventArgs e)
        {
            ADMINBILGI admin = new ADMINBILGI();
           
            if (admin.AdminKullaniciAd == txtKULLANICIADGIRIS.Text && admin.AdminSifre == txtSIFREGIRIS.Text)
            {
                this.Hide();
                
                frmadminpaneli.Show();
               


            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da Şifre hatalı.Lütfen Bilgilerinizi Kontrol Edin", "GİRİŞ BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
