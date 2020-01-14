using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;


namespace BUSINESSLOGICLAYER
{
    public class BLLRANDEVULAR
    {
        public static List<ENTITYRANDEVULAR> LISTELE()
        {
            return FACADERANDEVULAR.RANDEVULISTELE();
        }
    }
}
