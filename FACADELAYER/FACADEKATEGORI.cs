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
    public class FACADEKATEGORI 
    {
       
        public static bool KATEGORIEKLE(ENTITYKATEGORI deger)
        {
            SqlCommand komut = new SqlCommand("KATEGORIEKLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KATEGORIAD", deger.KATEGORIAD);
            return komut.ExecuteNonQuery()>0;
        }
        public static bool KATEGORISIL(int deger)
        {
            SqlCommand komut = new SqlCommand("KATEGORISIL",SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KATEGORIID", deger);
            return komut.ExecuteNonQuery() > 0;
        }
        public static bool KATEGORIGUNCELLE(ENTITYKATEGORI deger)
        {
            SqlCommand komut = new SqlCommand("KATEGORIGUNCELLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KATEGORIAD", deger.KATEGORIAD);
            komut.Parameters.AddWithValue("KATEGORIID", deger.KATEGORIID);

            return komut.ExecuteNonQuery() > 0;
        }

       
          
        
        public static List<ENTITYKATEGORI> KATEGORILISTESI()
        {
            List<ENTITYKATEGORI> degerler = new List<ENTITYKATEGORI>();
            SqlCommand komut = new SqlCommand("KATEGORILISTELE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTITYKATEGORI ent = new ENTITYKATEGORI();
                ent.KATEGORIID =Convert.ToInt32( dr["KategoriID"]);
                ent.KATEGORIAD= dr["KategoriAd"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

           

        }
    }
}
