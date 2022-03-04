using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisProjesi.DataAccess.BaglantiDAL
{
    class Baglanti
    {
        static SqlConnection baglantiNesnesi=null;

        public static SqlConnection BaglantiNesnesi
        {
            get {
                if (baglantiNesnesi==null)
                {
                    baglantiNesnesi = new SqlConnection(ConfigurationManager.ConnectionStrings["CsSatisProjesi"].ConnectionString);
                }
                return baglantiNesnesi;
            
            }
            set { baglantiNesnesi = value; }
        }
        public static void BaglantiAc()

        {
            if (BaglantiNesnesi.State==ConnectionState.Closed)
            {
                BaglantiNesnesi.Open();
            }
        }

        public static void BaglantiKapat()

        {
            if (BaglantiNesnesi.State == ConnectionState.Open)
            {
                BaglantiNesnesi.Close();
            }
        }
    }
}
