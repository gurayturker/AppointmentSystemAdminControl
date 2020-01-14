using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    public class ENTITYISYERIYETKILI:ENTITYILETISIM
    {
        private int yetkiliID;
        private string KullaniciAd;
        private string Sifre;
        private string TC;
        private string Soyad;
        private string DogumTarihi;
        private string Adres;

        public int YETKILIID
        {
            get 
            {
                return yetkiliID; 
            }
            set 
            {
                yetkiliID = value; 
            }
        }
        public string KULLANICIAD
        {
            get
            {
                return KullaniciAd; 
            }
            set 
            {
                KullaniciAd= value; 
            }
        }
        public string SIFRE
        {
            get
            {
                return Sifre;
            }
            set
            {
                Sifre = value;
            }
        }
        public string TCKIMLIK
        {
            get
            {
                return TC;
            }
            set
            {
                TC= value;
            }
        }
       
        public string SOYAD
        {
            get
            {
                return Soyad;
            }
            set
            {
                Soyad = value;
            }
        }
        public string DOGUMTARIHI
        {
            get
            {
                return DogumTarihi;
            }
            set
            {
                DogumTarihi= value;
            }
        }

      
        public string ADRES
        {
            get
            {
                return Adres;
            }
            set
            {
               Adres = value;
            }
        }




    }
}
