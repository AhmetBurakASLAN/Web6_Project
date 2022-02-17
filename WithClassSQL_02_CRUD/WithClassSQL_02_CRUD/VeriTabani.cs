using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSQL_02_CRUD
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

            string baglantiCumlesi = @" Server=DESKTOP-8M7D7GE\SQLEXPRESS ;Database=sHastane ; User=sa;Pwd=123";
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
        public DataTable HastalariListele()
        {
            sorguCümlesi = $"SELECT * FROM tblHastalar";
            adapter = new SqlDataAdapter(sorguCümlesi, Baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void Ekle(string tcNo, string ad, string soyad, string cinsiyet, string adres,string telefon, string mail)
        {
            
                sorguCümlesi = $"INSERT INTO tblHastalar(TcNo,Ad,Soyad,Cinsiyet) VALUES ('{tcNo}','{ad}','{soyad}','{cinsiyet}')";
                komut = new SqlCommand(sorguCümlesi, Baglan());
                komut.ExecuteNonQuery();
                Kapat();
            
            
            
        }

        public void Düzelt(string ID,string tcNo, string ad, string soyad, string cinsiyet, string adres, string telefon, string mail)
        {
          
                sorguCümlesi = $"UPDATE tblHastalar SET  TcNo='{tcNo}',Ad='{ad}',Soyad='{soyad}',Cinsiyet='{cinsiyet}' where ID='{ID}'";
                komut = new SqlCommand(sorguCümlesi, Baglan());
                komut.ExecuteNonQuery();
                Kapat();
           
            
        }
        public void Sil(string ID)
        {
            sorguCümlesi = $"DELETE  FROM  tblHastalar  where ID='{ID}'";
            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        
    }
}

