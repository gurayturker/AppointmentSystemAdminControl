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
using System.Data.SqlClient;

namespace RandevuSistemiAdminPaneli
{
    public partial class FrmYETKILIEKLE : Form,IIslemler
    {
      
        public void temizle()
        {
             txtYETKILIKULLANICIADIEKLE.Clear();
             txtYETKILISIFREEKLE.Clear();
            txtYETKILIADEKLE.Clear();
            txtYETKILISOYADEKLE.Clear(); ;
            mskYETKILITCEKLE.Clear();
            mskYETKILIDOGUMEKLE.Clear();
            rchYETKILIADRESEKLE.Clear();
            mskYETKILITELEFONEKLE.Clear();
            txtYETKILIEPOSTAEKLE.Clear();

        }
        void YETKILILISTELE()
        {
            List<ENTITYISYERIYETKILI> YetkiliListesi = BLLISYERIYETKILI.LISTELE();
            dataYETKILIEKLEKULLANICI.DataSource = YetkiliListesi;
        }
        public FrmYETKILIEKLE()
        {
            InitializeComponent();
        }

        private void FrmYETKILIEKLE_Load(object sender, EventArgs e)
        {
            YETKILILISTELE();
        }

        private void btnYETKILIEKLE_Click(object sender, EventArgs e)
        {
            try
            {
                
                    ENTITYISYERIYETKILI ent = new ENTITYISYERIYETKILI();
                    ent.KULLANICIAD = txtYETKILIKULLANICIADIEKLE.Text;
                    ent.SIFRE = txtYETKILISIFREEKLE.Text;
                    ent.AD= txtYETKILIADEKLE.Text;
                    ent.SOYAD = txtYETKILISOYADEKLE.Text;
                    ent.TCKIMLIK = mskYETKILITCEKLE.Text;
                    ent.DOGUMTARIHI= mskYETKILIDOGUMEKLE.Text;
                    ent.ADRES= rchYETKILIADRESEKLE.Text;
                    ent.TELEFON = mskYETKILITELEFONEKLE.Text;
                    ent.EPOSTA = txtYETKILIEPOSTAEKLE.Text;
                    BLLISYERIYETKILI.EKLE(ent);
                    MessageBox.Show("YETKİLİ EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
              
                YETKILILISTELE();

            }
            catch 
            {

                MessageBox.Show("ZORUNLU ALANLARI LÜTFEN DOLDURUNUZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
