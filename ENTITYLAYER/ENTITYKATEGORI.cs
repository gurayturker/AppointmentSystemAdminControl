using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
     public class ENTITYKATEGORI
    {
        private int KategoriID;
        private string KategoriAd;
        public int KATEGORIID
        {
            get { return KategoriID; }
            set { KategoriID = value; }
        }
        public string KATEGORIAD
        {
            get { return KategoriAd; }
            set { KategoriAd = value; }
        }
    }
}
