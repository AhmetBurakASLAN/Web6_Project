using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulaması.Entities
{
    class Calisan:IBasicEntity
    {
        // Bu class b,z,m etities katmanımızdadır.
        //Tablolarımızdan tblCalisanlar'ait bir entiti için hazırlanmıştır.
        
       
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string PersonelNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Departman { get; set; }
        public string Unvan { get; set; }
        public string Durumu { get; set; }
        public int ID { get; set ; }
        public string Ad { get ; set ; }
    }
}
