using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;
namespace BUSINESSLOGICLAYER
{
   public class BLLISYERIYETKILI
    {
        public static bool EKLE(ENTITYISYERIYETKILI deger)
        {
            if(deger.KULLANICIAD!=null&& deger.SIFRE != null && deger.AD != null && deger.SOYAD != null && deger.ADRES != null && deger.EPOSTA != null && deger.TELEFON != null  && deger.TCKIMLIK != null && deger.DOGUMTARIHI != null)
            {
                return FACADEISYERIYETKILI.ISYERIYETKILIEKLE(deger);
            }
            return false;
        }
        public static bool SIL(int deger)
        {
            if (deger > 0)
            {
                return FACADEISYERIYETKILI.ISYERIYETKILISIL(deger);
            }
            return false;
        }
        public static bool GUNCELLE(ENTITYISYERIYETKILI deger)
        {
            if ( deger.YETKILIID>0&&deger.KULLANICIAD != null && deger.SIFRE != null && deger.AD != null && deger.SOYAD != null && deger.ADRES != null && deger.EPOSTA != null && deger.TELEFON != null && deger.TCKIMLIK != null && deger.DOGUMTARIHI != null)
            {
                return FACADEISYERIYETKILI.ISYERIYETKILIGUNCELLE(deger);
            }
            return false;
        }
        public static List<ENTITYISYERIYETKILI> LISTELE()
        {
            return FACADEISYERIYETKILI.ISYERIYETKILILISTE();
        }
        public static List<ENTITYILETISIM> ILETISIMBILGILERILISTELE()
        {
            return FACADEISYERIYETKILI.ISYERIYETKILIILETISIMLISTELE();
        }

    }
}
