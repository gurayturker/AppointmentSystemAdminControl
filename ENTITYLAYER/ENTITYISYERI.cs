using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ENTITYLAYER
{
     public class ENTITYISYERI:ENTITYILETISIM
    {
        private int IsyeriID;
        private int IsyeriYetkiliID;
        private int IsyeriKategori;
        private string IsyeriAdres;
        private string IsyeriAcilisSaati;
        private string IsyeriKapanisSaati;
        private string IsyeriCalismaTarih;
       
        public int ISYERIID
        {
            get { return IsyeriID; }
            set { IsyeriID = value; }
        }
        public int ISYERIYETKILIID
        {
            get { return IsyeriYetkiliID; }
            set { IsyeriYetkiliID = value; }
        }
       
        public int ISYERIKATEGORI
        {
            get { return IsyeriKategori; }
            set { IsyeriKategori = value; }
        }
        public string ISYERIADRES
        {
            get { return IsyeriAdres; }
            set { IsyeriAdres = value; }
        }
        public string ISYERIACILISSAATI
        {
            get { return IsyeriAcilisSaati; }
            set { IsyeriAcilisSaati = value; }
        }
        public string ISYERIKAPANISSAATI
        {
            get { return IsyeriKapanisSaati; }
            set { IsyeriKapanisSaati = value; }
        }
        public string ISYERICALISMATARIH
        {
            get { return IsyeriCalismaTarih; }
            set { IsyeriCalismaTarih = value; }
        }
    
        



    }
}
