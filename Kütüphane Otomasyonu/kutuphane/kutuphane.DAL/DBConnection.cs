using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace kutuphane.DAL
{
    public class DBConnection
    {
        private readonly string connectionString;

        public DBConnection(){
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=kutuphane.accdb"; // Veritabanı bağlantısı için gereken adres.
        }
        private OleDbConnection accessConnection() // Bağlantı açılır ve durumu hakkında işlem yapılır.
        {
            OleDbConnection con = new OleDbConnection(connectionString);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
                con.Open();
            return con;
        }
        public OleDbCommand accessCommand() // Sorgu oluşturulur.
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = accessConnection();
            return cmd;
        }


    }
}
