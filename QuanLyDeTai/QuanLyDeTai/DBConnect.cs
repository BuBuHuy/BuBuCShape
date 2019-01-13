using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace QuanLyDeTai
{
    class DBConnect
    {
        static private string GetConnectionString()
        {
            return @"Data Source=PHI-LONG-TECHNO\SQLEXPRESS;Initial Catalog=QuanLyDeTai;Integrated Security=True";
        }
        public static SqlConnection openConnection()
        {
            string stringConnect = GetConnectionString();
            try
            {
                SqlConnection con = new SqlConnection(stringConnect);
                return con;
            }
            catch (Exception ex)
            {
                Console.Write("Connect Database Error : " + ex);
                throw ex;
            }

        }
    }
}
