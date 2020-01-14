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
    public partial class FrmRANDEVULAR : Form
    {
        void RandevuListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT RandevuID,UPPER(STANDARTKULLANICILAR.Ad+' '+STANDARTKULLANICILAR.Soyad) AS 'ADSOYAD',ISYERLERI.IsyeriAd,RandevuSaat,RandevuTarih FROM RANDEVULAR INNER JOIN STANDARTKULLANICILAR ON STANDARTKULLANICILAR.StandartKullaniciID = RANDEVULAR.RandevuAlanID INNER JOIN ISYERLERI ON ISYERLERI.IsyeriID = RANDEVULAR.IsyeriID", SQLBAGLANTISI.baglanti);
            da.Fill(dt);
            gridControlRANDEVULAR.DataSource = dt;
        }
        public FrmRANDEVULAR()
        {
            InitializeComponent();
        }

        private void FrmRANDEVULAR_Load(object sender, EventArgs e)
        {
            RandevuListele();
        }
    }
}
