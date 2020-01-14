using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
   public class ENTITYILETISIM
    {
        private string Telefon;
        private string Fax;
        private string Eposta;
        private string IsyeriAd;
        private string Ad;
        public string TELEFON
        {
            get { return Telefon; }
            set { Telefon = value; }
        }
        public string FAX
        {
            get { return Fax; ; }
            set { Fax = value; }
        }
        public string EPOSTA
        {
            get { return Eposta; }
            set { Eposta = value; }
        }
        public string ISYERIAD
        {
            get { return IsyeriAd; }
            set { IsyeriAd = value; }
        }
        public string AD
        {
            get
            {
                return Ad;
            }
            set
            {
                Ad = value;
            }
        }


    }
}
