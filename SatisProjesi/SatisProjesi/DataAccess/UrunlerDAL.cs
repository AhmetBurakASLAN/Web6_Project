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
    class UrunlerDAL
    {

        public List<Urunler> GetAll(string kosulCümlesi = "")
        {
            List<Urunler> ürünler = new List<Urunler>();
            try
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblUrunler { kosulCümlesi }", Baglanti.BaglantiNesnesi))
                {
                    Baglanti.BaglantiAc();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Urunler ürün = new Urunler
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                                UrunAd = reader["UrunAd"].ToString()
                                

                            };
                            ürünler.Add(ürün);

                        }

                    }


                }
                return ürünler;
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

        public int StokMiktarıGetir(string kosulCümlesi = "")
        {
            int stokMiktari = 0;
            try
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM tblUrunler { kosulCümlesi }", Baglanti.BaglantiNesnesi))
                {
                    Baglanti.BaglantiAc();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Urunler ürün = new Urunler
                            {
                                
                                StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                                
                            };
                            stokMiktari = ürün.StokMiktari;
                            MessageBox.Show(stokMiktari.ToString());
                        }

                    }


                }
                return stokMiktari;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
                //throw;
            }
            finally
            {
                Baglanti.BaglantiKapat();
            }
        }
        public int Update(Urunler urun)
        {
            int result = 1;
            short adet = 0;
           
                string sorguCumlesi =
                $"UPDATE tblUrunler SET StokMiktari = @p1 WHERE ID = @p2";
             urun = new Urunler();
                try
                {
                    using (SqlCommand command = new SqlCommand(sorguCumlesi, Baglanti.BaglantiNesnesi))
                    {
                        command.Parameters.AddWithValue("@p1", urun.StokMiktari);
                        
                        command.Parameters.AddWithValue("@p2", urun.ID);
                        Baglanti.BaglantiAc();
                        command.ExecuteNonQuery();
                    }
                    result = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    result = 0;
                }
                finally
                {
                Baglanti.BaglantiKapat();
            }
            
            return 1;

        }
    }
    
}
