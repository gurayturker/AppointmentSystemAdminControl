using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;

namespace BUSINESSLOGICLAYER
{
  public  class BLLKATEGORI
    {
        public static bool EKLE(ENTITYKATEGORI deger)
        {
            if (deger.KATEGORIAD != null)
            {
                return FACADEKATEGORI.KATEGORIEKLE(deger);
            }
            return false;
        }
        public static bool GUNCELLE(ENTITYKATEGORI deger)
        {
            if (deger.KATEGORIAD!=null&& deger.KATEGORIID > 0)
            {
                return FACADEKATEGORI.KATEGORIGUNCELLE(deger);
            }
            return false;
        }
        public static bool SIL(int deger)
        {
            if (deger > 0)
            {
                return FACADEKATEGORI.KATEGORISIL(deger);
            }
            return false;
        }
        public static List<ENTITYKATEGORI> LISTELE()
        {
            return FACADEKATEGORI.KATEGORILISTESI();
        }
    }
}
