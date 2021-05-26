using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace kutuphane.DAL
{
    public class UyeDAL
    {
        private DBConnection dBConnection;
        public UyeDAL()
        {
            dBConnection = new DBConnection(); // Bağlantı sınıfından nesne türetildi. 
            //Aşağıdaki listeleme,ekleme vb durumlarda oluşan değişiklikler için veritabanı ile bağlantısında kullanılacak.
        }
        public DataTable uyeListele()
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM uyeler";// Listelemesi gereken sorgu oluşturuldu.

            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            return dt;
        }
        public void uyeEkle(int tcKimlik, string uyeAd, string uyeSoyad, string telefon, string mail, string adres)
        {
            string cmdText = "INSERT INTO uyeler(TCKimlikNo,uyeAdi,uyeSoyadi,telefon,eposta,adres,borc) " +
                    "VALUES ('" + tcKimlik + "','" + uyeAd + "','" + uyeSoyad +
                    "','" + telefon + "','" + mail + "','" + adres + "'," + 0 + ")";
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();            
        }
        public void uyeSil(int tcKimlik)
        {
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = string.Format("DELETE FROM uyeler WHERE TCKimlikNo=" + tcKimlik + "");
            cmd.ExecuteNonQuery();
        }
        public void uyeGuncelle(int tcKimlik, string uyeAd, string uyeSoyad, string telefon, string mail, string adres)
        {
            string cmdText = "UPDATE uyeler SET uyeAdi='" + uyeAd + "', uyeSoyadi='" + uyeSoyad + "'," +
                " telefon='" + telefon + "', eposta='" + mail + "', adres='" + adres + "' WHERE  TCKimlikNo = " + tcKimlik + "";
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
    }
}
