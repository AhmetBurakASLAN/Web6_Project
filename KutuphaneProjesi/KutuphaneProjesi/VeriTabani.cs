using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    class VeriTabani

    {
        //il olarak bir veritabanı bağlantısı yapacak metot hazırlayalım
        SqlConnection baglanti;
        string sorguCümlesi;
        SqlCommand komut;
        SqlDataAdapter adapter;
        DataTable dt;
        
        public SqlConnection Baglan()
        {

            string baglantiCumlesi = @" Server=DESKTOP-8M7D7GE\SQLEXPRESS ;Database=sKutuphane ; User=sa;Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            return baglanti;

        }

        public void Kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();

            }
        }
        public DataTable KayitListele(string sorguCümlesi)
        {
            
            adapter = new SqlDataAdapter(sorguCümlesi, Baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void Islem(string sorguCümlesi,string turAd)
        {
            
                komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.Parameters.AddWithValue("@turAd", turAd);

                komut.ExecuteNonQuery();
                Kapat();
                                    
        }

        public void TurEkle(string sorguCümlesi, string turAd)
        {

            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.Parameters.AddWithValue("@turAd", turAd);

            komut.ExecuteNonQuery();
            Kapat();

        }

        public void KitapEkle(string sorguCümlesi,string ISBN,string ad, int sayfaSayisi,int stok,int turID,int yazarID,int yayineviID )
        {
            komut = new SqlCommand(sorguCümlesi, Baglan());
            //@Kitapadı,@KitapISBN,@SayfaSayisi,@Stok,@TurID,@YayinEviID,YazarID)
            komut.Parameters.AddWithValue("@KitapISBN", ISBN);
            komut.Parameters.AddWithValue("@KitapAdi", ad);
            komut.Parameters.AddWithValue("@KitapSayfaSayisi", sayfaSayisi);
            komut.Parameters.AddWithValue("@KitapStok", stok);
            komut.Parameters.AddWithValue("@KitapTurID", turID);
            komut.Parameters.AddWithValue("@KitapYazarID", yazarID);
            komut.Parameters.AddWithValue("@KitapYayinEviID", yayineviID);

            komut.ExecuteNonQuery();
            Kapat();



        }
    }
}

