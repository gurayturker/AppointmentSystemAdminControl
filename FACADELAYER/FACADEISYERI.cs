using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTITYLAYER;

namespace FACADELAYER
{
    public class FACADEISYERI 
    {
       
        public static bool ISYERIEKLE(ENTITYISYERI deger)

        {
            SqlCommand komut = new SqlCommand("ISYERIEKLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("ISYERIAD", deger.ISYERIAD);
            komut.Parameters.AddWithValue("ISYERIYETKILIID", deger.ISYERIYETKILIID);
            komut.Parameters.AddWithValue("ISYERIKATEGORI", deger.ISYERIKATEGORI);
            komut.Parameters.AddWithValue("ISYERIADRES", deger.ISYERIADRES);
            komut.Parameters.AddWithValue("ISYERIACILISSAATI", deger.ISYERIACILISSAATI);
            komut.Parameters.AddWithValue("ISYERIKAPANISSAATI", deger.ISYERIKAPANISSAATI);
            komut.Parameters.AddWithValue("ISYERICALISMATARIH", deger.ISYERICALISMATARIH);
            komut.Parameters.AddWithValue("ISYERITEL", deger.TELEFON);
            komut.Parameters.AddWithValue("ISYERIFAX", deger.FAX);
            komut.Parameters.AddWithValue("ISYERIEPOSTA", deger.EPOSTA);
           return  komut.ExecuteNonQuery()>0;
        

           
        }
        public static bool ISYERISIL(int deger)
        {
            SqlCommand komut = new SqlCommand("ISYERISIL", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("ISYERIID", deger);

            return komut.ExecuteNonQuery() > 0;
        }
        public static bool ISYERIGUNCELLE(ENTITYISYERI deger)
        {
            SqlCommand komut = new SqlCommand("ISYERIGUNCELLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("ISYERIID", deger.ISYERIID);
            komut.Parameters.AddWithValue("ISYERIAD", deger.ISYERIAD);
            komut.Parameters.AddWithValue("ISYERIYETKILIID", deger.ISYERIYETKILIID);
            komut.Parameters.AddWithValue("ISYERIKATEGORI", deger.ISYERIKATEGORI);
            komut.Parameters.AddWithValue("ISYERIADRES", deger.ISYERIADRES);
            komut.Parameters.AddWithValue("ISYERIACILISSAATI", deger.ISYERIACILISSAATI);
            komut.Parameters.AddWithValue("ISYERIKAPANISSAATI", deger.ISYERIKAPANISSAATI);
            komut.Parameters.AddWithValue("ISYERICALISMATARIH", deger.ISYERICALISMATARIH);
            komut.Parameters.AddWithValue("ISYERITEL", deger.TELEFON);
            komut.Parameters.AddWithValue("ISYERIFAX", deger.FAX);
            komut.Parameters.AddWithValue("ISYERIEPOSTA", deger.EPOSTA);


            return komut.ExecuteNonQuery() > 0;
        }
        public static List<ENTITYISYERI> ISYERILISTELE()
        {
            List<ENTITYISYERI> degerler = new List<ENTITYISYERI>();
            SqlCommand komut = new SqlCommand("ISYERILISTELE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                ENTITYISYERI ent = new ENTITYISYERI();
                ent.ISYERIID = Convert.ToInt32(dr["IsyeriID"]);
                ent.ISYERIAD = dr["IsyeriAd"].ToString();
                ent.ISYERIYETKILIID = Convert.ToInt32( dr["IsyeriYetkiliID"]);
                ent.ISYERIKATEGORI= Convert.ToInt32(dr["IsyeriKategori"]);
                ent.ISYERIADRES = dr["IsyeriAdres"].ToString();
                ent.ISYERIACILISSAATI =dr["IsyeriAcilisSaati"].ToString();
                ent.ISYERIKAPANISSAATI = dr["IsyeriKapanisSaati"].ToString();
                ent.ISYERICALISMATARIH = dr["IsyeriCalismaTarih"].ToString();
                ent.TELEFON= dr["IsyeriTel"].ToString();
                ent.FAX = dr["IsyeriFax"].ToString();
                ent.EPOSTA=dr["IsyeriEposta"].ToString();



                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static List<ENTITYILETISIM> ISYERIILETISIMBILGILERI()
        {
            List<ENTITYILETISIM> degerler = new List<ENTITYILETISIM>();
            SqlCommand komut = new SqlCommand("ISYERIILETISIMLISTELE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTITYILETISIM ent = new ENTITYILETISIM();
                
                ent.ISYERIAD = dr["IsyeriAd"].ToString();
                ent.FAX = dr["IsyeriFax"].ToString();
                ent.TELEFON = dr["IsyeriTel"].ToString();
                ent.EPOSTA = dr["IsyeriEposta"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
     

    }
}

