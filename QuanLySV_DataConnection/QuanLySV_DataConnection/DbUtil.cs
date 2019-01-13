using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace QuanLySV_DataConnection
{
    class DbUtil
    {
        static private string GetConnectionString()
        {
            return @"Data Source=PHI-LONG-TECHNO;Initial Catalog=QuanLySVDB;Integrated Security=True";
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
