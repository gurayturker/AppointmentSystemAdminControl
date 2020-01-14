using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data.SqlClient;
using System.Data;


namespace FACADELAYER
{
    public class FACADERANDEVULAR
    {
        public static List<ENTITYRANDEVULAR> RANDEVULISTELE()
        {
            List<ENTITYRANDEVULAR> degerler = new List<ENTITYRANDEVULAR>();
            SqlCommand komut = new SqlCommand("RANDEVULISTELE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTITYRANDEVULAR ent = new ENTITYRANDEVULAR();
                ent.RandevuID = Convert.ToInt32(dr["RandevuID"]);
                ent.RandevuAlanID = dr["RandevuAlanID"].ToString();
                ent.IsyeriID = dr["IsyeriID"].ToString();
                ent.RandevuSaat = dr["RandevuSaat"].ToString();
                ent.RandevuTarih = dr["RandevuTarih"].ToString();
                degerler.Add(ent);

            }
            dr.Close();
            return degerler;
        }
    }
}
