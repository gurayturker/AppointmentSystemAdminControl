using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;

namespace BUSINESSLOGICLAYER
{
   public class BLLISYERI
    { 
        public static bool EKLE(ENTITYISYERI deger)
        {
            
            if (deger.ISYERIAD!=null&& deger.ISYERIYETKILIID > 0 && deger.ISYERIKATEGORI> 0 && deger.ISYERIACILISSAATI!= null && deger.ISYERIKAPANISSAATI != null && deger.ISYERICALISMATARIH!= null && deger.ISYERIADRES != null && deger.TELEFON != null
                && deger.FAX != null&&deger.EPOSTA!=null )
            {
                
                return FACADEISYERI.ISYERIEKLE(deger);
            }
            return false;
        }
        public static bool SIL(int deger)
        {
            if (deger > 0)
            {
                return FACADEISYERI.ISYERISIL(deger);
            }
            return false;
        }
        public static bool GUNCELLE(ENTITYISYERI deger)
        {
            if ( deger.ISYERIID>0&&deger.ISYERIAD != null && deger.ISYERIYETKILIID > 0 && deger.ISYERIKATEGORI> 0 && deger.ISYERIACILISSAATI != null && deger.ISYERIKAPANISSAATI != null && deger.ISYERICALISMATARIH != null && deger.ISYERIADRES != null && deger.TELEFON != null && deger.FAX != null && deger.EPOSTA != null)
            {
                return FACADEISYERI.ISYERIGUNCELLE(deger);
            }
            return false;
        }
        public static List<ENTITYISYERI> LISTELE()
        {
            return FACADEISYERI.ISYERILISTELE();
        }
        public static List<ENTITYILETISIM> ILETISIMBILGILERILISTELE()
        {
            return FACADEISYERI.ISYERIILETISIMBILGILERI();
        }
    }
}
