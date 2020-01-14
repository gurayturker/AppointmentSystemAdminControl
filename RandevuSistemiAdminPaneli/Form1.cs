using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//AUTHOR:GÜRAY TÜRKER 22/12/2019


namespace RandevuSistemiAdminPaneli
{
    public partial class FrmADMINPANELI : Form
    {
        public FrmADMINPANELI()
        {
            InitializeComponent();
        }
        FrmISYERIEKLE frmisyeriekle;
        FrmIsyerleri frmisyeri;
        FrmKategoriler frmkategori;
        FrmYetkililer frmyetkili;
        FrmYETKILIEKLE frmyetkiliekle;
        FrmKATEGORIEKLE frmkategoriekle;
        FrmISYERISIL frmisyerisil;
        FrmYETKILISIL frmyetkilisil;
        FrmKATEGORISIL kategorisil;
        FrmISYERIGUNCELLE frmisyeriguncelle;
        FrmYETKILIGUNCELLE frmyetkiliguncelle;
        FrmKATEGORIGUNCELLE frmkategoriguncelle;
        FrmRANDEVULAR frmrandevular;
        FrmISYERIILETISIM frmisyeriiletisim;
        FrmYETKILIILETISIM frmyetkiliiletisim;
        FrmMAILGONDER frmmailgonder;
        FrmAnasayfa frmanasayfa;
        void ANASAYFAGETIR()
        {
            frmanasayfa = new FrmAnasayfa();
            frmanasayfa.MdiParent = this;
            frmanasayfa.Show();
        }


        private void dropISYERIEKLE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmisyeriekle = new FrmISYERIEKLE();
            frmisyeriekle.MdiParent = this;
            frmisyeriekle.Show();
        }

        private void btnISYERLERI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmisyeri = new FrmIsyerleri();
            frmisyeri.MdiParent = this;
            frmisyeri.Show();
        }

        private void btnYETKILI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmyetkili = new FrmYetkililer();
            frmyetkili.MdiParent = this;
            frmyetkili.Show();
        }

        private void btnKATEGORI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmkategori = new FrmKategoriler();
            frmkategori.MdiParent = this;
            frmkategori.Show();
        }

        private void dropYETKILIEKLE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmyetkiliekle = new FrmYETKILIEKLE();
            frmyetkiliekle.MdiParent = this;
            frmyetkiliekle.Show();
        }

        private void dropKATEGORIEKLE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmkategoriekle = new FrmKATEGORIEKLE();
            frmkategoriekle.MdiParent = this;
            frmkategoriekle.Show();
        }

        private void dropISYERISIL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmisyerisil = new FrmISYERISIL();
            frmisyerisil.MdiParent = this;
            frmisyerisil.Show();

        }

        private void dropYETKILISIL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmyetkilisil = new FrmYETKILISIL();
            frmyetkilisil.MdiParent = this;
            frmyetkilisil.Show();

        }

        private void dropKATEGORISIL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            kategorisil = new FrmKATEGORISIL();
            kategorisil.MdiParent = this;
            kategorisil.Show();
        }

        private void dropISYERIGUNCELLE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmisyeriguncelle = new FrmISYERIGUNCELLE();
            frmisyeriguncelle.MdiParent = this;
            frmisyeriguncelle.Show();
        }

        private void dropYETKILIGUNCELLE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmyetkiliguncelle = new FrmYETKILIGUNCELLE();
            frmyetkiliguncelle.MdiParent = this;
            frmyetkiliguncelle.Show();

        }

        private void dropKATEGORIGUNCELLE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmkategoriguncelle = new FrmKATEGORIGUNCELLE();
            frmkategoriguncelle.MdiParent = this;
            frmkategoriguncelle.Show();
        }

        private void dropISYERILISTELE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmisyeri = new FrmIsyerleri();
            frmisyeri.MdiParent = this;
            frmisyeri.Show();
        }

        private void dropYETKILILISTELE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmyetkili = new FrmYetkililer();
            frmyetkili.MdiParent = this;
            frmyetkili.Show();
        }

        private void dropKATEGORILISTELE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmkategori = new FrmKategoriler();
            frmkategori.MdiParent = this;
            frmkategori.Show();
        }

        private void btnRANDEVULAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmrandevular = new FrmRANDEVULAR();
            frmrandevular.MdiParent = this;
            frmrandevular.Show();

        }

        private void btnISYERIILETISIMBILGILERI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmisyeriiletisim = new FrmISYERIILETISIM();
            frmisyeriiletisim.MdiParent = this;
            frmisyeriiletisim.Show();
        }

        private void btnYETKILIILETISIMBILGILERI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmyetkiliiletisim = new FrmYETKILIILETISIM();
            frmyetkiliiletisim.MdiParent = this;
            frmyetkiliiletisim.Show();
        }

        private void btnGONDER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmmailgonder = new FrmMAILGONDER();
            frmmailgonder.Show();
        }

        private void FrmADMINPANELI_Load(object sender, EventArgs e)
        {
            ANASAYFAGETIR();

        }

        private void btnANASAYFALISTELE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ANASAYFAGETIR();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ANASAYFAGETIR();
        }

        private void btnANASAYFARANDEVULAER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ANASAYFAGETIR();
        }

        private void btnANASAYFAILETISIM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ANASAYFAGETIR();
        }

        private void btnYETKILII_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmyetkili = new FrmYetkililer();
            frmyetkili.MdiParent = this;
            frmyetkili.Show();
        }
    }
    }

