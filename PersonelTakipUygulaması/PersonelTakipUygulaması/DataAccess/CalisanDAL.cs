using PersonelTakipUygulaması.Entities;
using PersonelTakipUygulaması.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulaması.DataAccess
{
    class CalisanDAL
    {
        //Burada ise Data Access Layer hazırlıyoruz
        //Yani Calisan entitiemizle ilgili CRUD vb. işlemlerimiz burda gerçekleştirilecek.
        /// <summary>
        /// Bu metot geriye içinde calisan tipinde değerler barındıran list tipinde değer döndürecek
        /// </summary>
        /// <param name="kosulCümlesi">
        /// Bu parametre boş bırakılırsa veya string.empty şeklinde tüm kayıtları döndürecek.
        /// Eğer buraya uygun bir Where ifadesi yazılırsa koşula uygun WHERE ifadesi yazılırsa koşula uygun kayıtları döndürecek.
        /// </param>
        /// <returns></returns>
        public List <Calisan> GetAll (string kosulCümlesi="")
        {
            List<Calisan> calisanlar = new List<Calisan>();
            try
            {
                // Buraya yazacağımız işlemleri dene sorun yoksa çalıştır.
                using ( SqlCommand command = new SqlCommand($"SELECT * FROM tblCalisanlar {kosulCümlesi}", SQLBaglanti.Baglanti))
                {
                    // Using satırında yaratılan command adlı nesne sadece 
                    //bu scopeda yaşayacak.Bu scope dışında yok olmuş olacak.
                    //Bu nesnenin yok edilmesini Garbage Collector'ün 
                    // insiyatifine bırakmamış olduk.
                    SQLBaglanti.BaglantiAc();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())// geri dönen değerlerin hepsine bakmamızı sağlar
                        {
                            Calisan calisan = new Calisan
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TcNo = reader["TcNo"].ToString(),
                                PersonelNo = reader["PersonelNo"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                IseBaslamaTarihi = Convert.ToDateTime(reader["IseBaslamaTarihi"]),
                                Departman = reader["Departman"].ToString(),
                                Unvan = reader["Unvan"].ToString(),
                                Durumu = reader["Durumu"].ToString()
                            };

                            calisanlar.Add(calisan);
                        }
                    }
                }
                return calisanlar;
            }
            catch (Exception ex )
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
        public bool Insert(Calisan calisan)
        {
            if (Dublicate($"WHERE PersonelNo ='{calisan.PersonelNo}'") == 1 || Dublicate($"WHERE TcNo ='{calisan.PersonelNo}'") == 1)
            {
                //mesaj
                MessageBox.Show("Bu personel no ile daha önce kayıt oluşturulmuş");
                return false;
            }
            else
            {

                string sorguCümlesi =
                    $"INSERT INTO tblCalisanlar" +
                    $"(Ad,Soyad,TcNo,PersonelNo,DogumTarihi,IseBaslamaTarihi," +
                    $"Departman,Unvan,Durumu) VALUES " +
                    $"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
                try
                {
                    using (SqlCommand command = new SqlCommand(sorguCümlesi, SQLBaglanti.Baglanti))
                    {
                        command.Parameters.AddWithValue("@p1", calisan.Ad);
                        command.Parameters.AddWithValue("@p2", calisan.Soyad);
                        command.Parameters.AddWithValue("@p3", calisan.TcNo);
                        command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                        command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                        command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi);
                        command.Parameters.AddWithValue("@p7", calisan.Departman);
                        command.Parameters.AddWithValue("@p8", calisan.Unvan);
                        command.Parameters.AddWithValue("@p9", calisan.Durumu);
                        SQLBaglanti.BaglantiAc();
                        command.ExecuteNonQuery();
                    }
                    return true; // Kayıt başarılı anlamında
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    SQLBaglanti.BaglantiKapat();
                }
                return true;
            }
        }
        public bool Update(Calisan calisan,string orjinalPersonelNo)
        {
            bool result = false;
            short adet = 0;
            if (calisan.PersonelNo != orjinalPersonelNo)
            {
                adet = Dublicate($"WHERE PersonelNo = '{calisan.PersonelNo}'");
               }


            if (adet == 1)
            {
                    result =false;
            }
            
            else
            {

                string sorguCümlesi =
                    $"UPDATE tblCalisanlar Set Ad = @p1,Soyad = @p2,TcNo = @p3,PersonelNo = @p4,DogumTarihi = @p5 ," +
                    $"IseBaslamaTarihi = @p6,Departman = @p7,Unvan = @p8,Durumu = @p9 WHERE ID = @p10";
                try
                {
                    using (SqlCommand command = new SqlCommand(sorguCümlesi, SQLBaglanti.Baglanti))
                    {
                        command.Parameters.AddWithValue("@p1", calisan.Ad);
                        command.Parameters.AddWithValue("@p2", calisan.Soyad);
                        command.Parameters.AddWithValue("@p3", calisan.TcNo);
                        command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                        command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                        command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi);
                        command.Parameters.AddWithValue("@p7", calisan.Departman);
                        command.Parameters.AddWithValue("@p8", calisan.Unvan);
                        command.Parameters.AddWithValue("@p9", calisan.Durumu);
                        command.Parameters.AddWithValue("@p10", calisan.ID);
                        SQLBaglanti.BaglantiAc();
                        command.ExecuteNonQuery();
                    }
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    result= false;
                }
                finally
                {
                    SQLBaglanti.BaglantiKapat();
                }
            }
            return result;
        }
        public bool Delete(int id)
        {
            string sorguCümlesi = $"DELETE FROM tblCalisanlar WHERE ID=@p1 ";

            try
            {
                using(SqlCommand command=new SqlCommand(sorguCümlesi,SQLBaglanti.Baglanti))
                {
                    command.Parameters.AddWithValue("@p1", id);
                    SQLBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
        public bool Delete (string kosulcümlesi="")
        {
            string sorguCümlesi =
                $"DELETE FROM tblCalisanlar {kosulcümlesi}";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCümlesi,SQLBaglanti.Baglanti))
                {
                    //command.Parameters.AddWithValue("@p1", kosulcümlesi);
                    SQLBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
            return true;
        }
        public Calisan Get(string kosulCümlesi)
        {
            Calisan calisan = null;
            int adet = 0;
            try
            {
                
                using (SqlCommand command=new SqlCommand($"SELECT COUNT (*) FROM tblCalisanlar {kosulCümlesi}",SQLBaglanti.Baglanti))

                {
                    SQLBaglanti.BaglantiAc();
                    adet =Convert.ToInt32(command.ExecuteScalar());
                    
                                          
                }
                if (adet>1)
               {
                    
                    MessageBox.Show($"Aradığınız kritere uygun cok sayıda kayıt var. \n Lütfen daha fazla kriter giriniz");
                    return null;
                }

                else if (adet==1)
                {
                    using (SqlCommand command=new SqlCommand($"SELECT * FROM tblCalisanlar {kosulCümlesi}",SQLBaglanti.Baglanti))
                    {
                        using (SqlDataReader okuyucu = command.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                calisan = new Calisan
                                {
                                    ID = Convert.ToInt32(okuyucu["ID"]),
                                    Ad = okuyucu["Ad"].ToString(),
                                    Soyad = okuyucu["Soyad"].ToString(),
                                    TcNo = okuyucu["TcNo"].ToString(),
                                    PersonelNo = okuyucu["PersonelNo"].ToString(),
                                    DogumTarihi = Convert.ToDateTime(okuyucu["DogumTarihi"]),
                                    IseBaslamaTarihi = Convert.ToDateTime(okuyucu["IseBaslamaTarihi"]),
                                    Departman = okuyucu["Departman"].ToString(),
                                    Unvan = okuyucu["Unvan"].ToString(),
                                    Durumu = okuyucu["Durumu"].ToString()
                                };
                            }
                        }
                    }
                    return calisan;
                }

                else
                {
                    MessageBox.Show("Aradığınız kriterlere uygun bir kayıt bulunamamıştır.\n Kütfen kriterleri değiştirerek tekrar arayınız");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + adet.ToString());
                return null;
                //throw;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
        public short Dublicate(string kosulCümlesi="")
        {
            short adet = 0;
            try
            {
                             
                using (SqlCommand command = new SqlCommand($"SELECT COUNT (*) FROM tblCalisanlar {kosulCümlesi}", SQLBaglanti.Baglanti))

                {
                    SQLBaglanti.BaglantiAc();
                    adet = Convert.ToInt16(command.ExecuteScalar());
                    //shorta cevirmek için toint short dite birşey yok toint16 var


                }

                return adet;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                return adet;
                //throw;
            }
            finally
            {
                SQLBaglanti.BaglantiKapat();
            }
        }
    }
    }

