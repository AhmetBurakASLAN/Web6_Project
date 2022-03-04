using SatisProjesi.DataAccess.BaglantiDAL;
using SatisProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisProjesi.DataAccess
{

   
    class SatisProjeDAL
    {

        public List<Satislar> GetAll(string kosulCümlesi = "")
        {
            List<Satislar> satislar = new List<Satislar>();
            try
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM vSatislar { kosulCümlesi }", Baglanti.BaglantiNesnesi))
                {
                    Baglanti.BaglantiAc();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Satislar satislar1 = new Satislar
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                SatisTarihi = Convert.ToDateTime(reader["SatisTarihi"]),
                                UrunAd = reader["UrunAd"].ToString(),
                                SatisAdedi = Convert.ToInt32(reader["SatisAdedi"]),

                            };
                            satislar.Add(satislar1);

                        }

                    }


                }
                return satislar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
                //throw;
            }
            finally
            {
                Baglanti.BaglantiKapat();
            }

        }
        public bool Insert(tblSatislar tblsatislar)
        {

            string kosulCümlesi = $"INSERT INTO tblSatislar VALUES (@p1,@p2,@p3) ";

            try
            {
                using (SqlCommand command = new SqlCommand(kosulCümlesi, Baglanti.BaglantiNesnesi))
                {
                    command.Parameters.AddWithValue("@p1", tblsatislar.SatisTarihi);
                    command.Parameters.AddWithValue("@p2", tblsatislar.UrunID);
                    command.Parameters.AddWithValue("@p3", tblsatislar.SatisAdedi);
                    Baglanti.BaglantiAc();
                    command.ExecuteNonQuery();


                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
                return false;

            }
            finally
            {
                Baglanti.BaglantiKapat();
            }

        }
    }
}
