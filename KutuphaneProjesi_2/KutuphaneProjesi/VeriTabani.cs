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
        SqlConnection baglanti;
        public DataTable dt;
        public string TableName { get; set; }
        public VeriTabani()
        {
            baglanti = NesneOlustur();
            Ac();
        }
        string sorguCümlesi;
        

        SqlConnection NesneOlustur()
        { 
            string server= $@"DESKTOP-8M7D7GE\SQLEXPRESS";
            string database="sKutuphane";
            string user="sa";
            string password="123";
            string baglantiCümlesi = $@"Server={server};Database={database};user={user}; Pwd={password}";
            baglanti = new SqlConnection(baglantiCümlesi);
            return baglanti;
            
        }

        public void Ac()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public void Kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();
            }
        }
        //public DataTable Dt { get; set; }
        public  void Islem()
        {

            sorguCümlesi = $"SELECT * FROM {TableName}";
            SqlDataAdapter adapter = new SqlDataAdapter(sorguCümlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            
        }
        public void Islem (int ID)
        {
            Ac();
            sorguCümlesi = $"UPDATE {TableName} SET  Iptal=1 WHERE ID ={ID}";
            SqlCommand komut = new SqlCommand(sorguCümlesi, baglanti);
            komut.ExecuteNonQuery();
            Kapat();

        }
        public void Islem(Odunc yeniOdunc)
         {
            Ac();
            sorguCümlesi = $"INSERT INTO {TableName}(UyeID,KitapISBN,VerilisTarihi,Iptal) VALUES (@uyeID,@kitapISBN,@verilisTarihi,@iptal)";
            SqlCommand komut = new SqlCommand(sorguCümlesi, baglanti);
            komut.Parameters.AddWithValue("@uyeID", yeniOdunc.UyeID);
            komut.Parameters.AddWithValue("@kitapISBN", yeniOdunc.KitapISBN);
            komut.Parameters.AddWithValue("@verilisTarihi",yeniOdunc.VerilisTarihi.ToString("yyyy-M-dd"));
            komut.Parameters.AddWithValue("@iptal", yeniOdunc.Iptal);

            komut.ExecuteNonQuery();
                 
            Kapat();

        }





    }



}

