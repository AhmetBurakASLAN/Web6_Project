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
        string sorguCümlesi;
        public VeriTabani() //Constructor Method
        {

        }

        public VeriTabani(string tabloAdi,params string [] sutunlar) //Bu overload kayıt listeleme yapacak
        {
            string sutunMetni = "";
            //string sorgucümlesi = $"SELECT {sutunlar} FROM {tabloAdi}";
            //foreach (var siradakiSutunAd in sutunlar)
            //{
            //    sutunMetni += siradakiSutunAd + ",";  
            //}
            //sutunMetni = sutunMetni.Substring(0, sutunMetni.Length - 1);
            sutunMetni = string.Join(",", sutunlar);
            sorguCümlesi=$"SELECT{sutunMetni} FROM {tabloAdi}";
            KayitListele(sorguCümlesi);


        }

        //il olarak bir veritabanı bağlantısı yapacak metot hazırlayalım
        SqlConnection baglanti;
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
         DataTable KayitListele(string sorguCümlesi)
        {
            
            adapter = new SqlDataAdapter(sorguCümlesi, Baglan());
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void Islem(string sorguCümlesi)
        {
            
                komut = new SqlCommand(sorguCümlesi, Baglan());
                komut.ExecuteNonQuery();
                Kapat();
            
            
            
        }

       
        
        
    }
}

