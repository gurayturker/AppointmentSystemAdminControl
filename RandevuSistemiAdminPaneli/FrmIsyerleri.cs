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
    public partial class FrmIsyerleri : Form
    {
        
        void IsyeriListele()
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select IsyeriID,IsyeriAd,YETKILILER.Ad+' '+YETKILILER.Soyad AS ' YETKİLİ ADSOYAD',KATEGORILER.KategoriAd,IsyeriTel,IsyeriFax,IsyeriEposta,IsyeriAdres,IsyeriAcilisSaati,IsyeriKapanisSaati,IsyeriCalismaTarih from ISYERLERI INNER JOIN YETKILILER  ON YETKILILER.YetkiliID = ISYERLERI.IsyeriYetkiliID INNER JOIN KATEGORILER ON ISYERLERI.IsyeriKategori = KATEGORILER.KategoriID", SQLBAGLANTISI.baglanti);
            da.Fill(dt);
            gridControlISYERLERI.DataSource = dt;
        }
        public FrmIsyerleri()
        {
            InitializeComponent();
        }

        private void FrmIsyerleri_Load(object sender, EventArgs e)
        {
            IsyeriListele();
        }
    }
}
