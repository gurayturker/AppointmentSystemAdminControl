using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTITYLAYER;

namespace FACADELAYER
{
   public class FACADEISYERIYETKILI
    {
       
        public static bool ISYERIYETKILIEKLE(ENTITYISYERIYETKILI deger)
        {
            SqlCommand komut = new SqlCommand("YETKILIEKLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
           
            komut.Parameters.AddWithValue("KULLANICIAD", deger.KULLANICIAD);
            komut.Parameters.AddWithValue("SIFRE", deger.SIFRE);
            komut.Parameters.AddWithValue("AD", deger.AD);
            komut.Parameters.AddWithValue("SOYAD", deger.SOYAD);
            komut.Parameters.AddWithValue("ADRES", deger.ADRES);
            komut.Parameters.AddWithValue("EPOSTA", deger.EPOSTA);
            komut.Parameters.AddWithValue("TELEFONNO", deger.TELEFON);
            komut.Parameters.AddWithValue("TC", deger.TCKIMLIK);
            komut.Parameters.AddWithValue("DOGUMTARIHI", deger.DOGUMTARIHI);
            return komut.ExecuteNonQuery()>0;
        }
        public static bool ISYERIYETKILISIL(int deger)
        {
            SqlCommand komut = new SqlCommand("YETKILISIL", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULLANICIID", deger);

            return komut.ExecuteNonQuery()>0;
        }
        public static bool ISYERIYETKILIGUNCELLE(ENTITYISYERIYETKILI deger)
        {
            SqlCommand komut = new SqlCommand("YETKILIGUNCELLE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULLANICIID", deger.YETKILIID);
            komut.Parameters.AddWithValue("KULLANICIAD", deger.KULLANICIAD);
            komut.Parameters.AddWithValue("SIFRE", deger.SIFRE);
            komut.Parameters.AddWithValue("AD", deger.AD);
            komut.Parameters.AddWithValue("SOYAD", deger.SOYAD);
            komut.Parameters.AddWithValue("ADRES", deger.ADRES);
            komut.Parameters.AddWithValue("EPOSTA", deger.EPOSTA);
            komut.Parameters.AddWithValue("TELEFONNO", deger.TELEFON);
            komut.Parameters.AddWithValue("TC", deger.TCKIMLIK);
            komut.Parameters.AddWithValue("DOGUMTARIHI", deger.DOGUMTARIHI);
            return komut.ExecuteNonQuery()>0;
        }
        public static List<ENTITYISYERIYETKILI> ISYERIYETKILILISTE()
        {
            List<ENTITYISYERIYETKILI> degerler = new List<ENTITYISYERIYETKILI>();
            SqlCommand komut = new SqlCommand("YETKILILISTELE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTITYISYERIYETKILI ent = new ENTITYISYERIYETKILI();
                ent.YETKILIID =Convert.ToInt32( dr["YetkiliID"]);
                ent.KULLANICIAD = dr["KullaniciAd"].ToString();
                ent.SIFRE = dr["Sifre"].ToString();
                ent.AD = dr["Ad"].ToString();
                ent.SOYAD = dr["Soyad"].ToString();
                ent.TCKIMLIK = dr["TC"].ToString();
                ent.DOGUMTARIHI = dr["DogumTarihi"].ToString();
                ent.EPOSTA = dr["Eposta"].ToString();
                ent.ADRES = dr["Adres"].ToString();
                ent.TELEFON = dr["TelefonNo"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static List<ENTITYILETISIM> ISYERIYETKILIILETISIMLISTELE()
        {
            List<ENTITYILETISIM> degerler = new List<ENTITYILETISIM>();
            SqlCommand komut = new SqlCommand("YETKILIILETISIMLISTELE", SQLBAGLANTISI.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTITYILETISIM ent = new ENTITYILETISIM();
                
                ent.AD = dr["Ad"].ToString();
                ent.TELEFON = dr["TelefonNo"].ToString();
                ent.EPOSTA = dr["Eposta"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        
    }
}
