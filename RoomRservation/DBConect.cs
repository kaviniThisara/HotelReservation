using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRservation
{
    class DBConect : IDisposable
    {

        private static String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\itp\RoomRservation\RoomRservation\hotelDB.mdf;Integrated Security=True";
        public SqlConnection con = new SqlConnection(connectionString);
        public SqlCommand cmd;

        public DBConect()
        {
            try
            {
                con.Open();
                Console.WriteLine("DB Connected successfully");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("DB Conection failed");
            }
        }

        public bool insert(String q)
        {

            try
            {
                cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }


        public void Dispose()
        {
            con.Close();
        }
    }
}
