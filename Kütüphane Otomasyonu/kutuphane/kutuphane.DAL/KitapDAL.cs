using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace kutuphane.DAL
{
    public class KitapDAL
    {
        private DBConnection dBConnection;
        public KitapDAL()
        {
            dBConnection = new DBConnection(); // Bağlantı sınıfından nesne türetildi. 
            //Aşağıdaki listeleme,ekleme vb durumlarda oluşan değişiklikler için veritabanı ile bağlantısında kullanılacak.
        }
        public DataTable kitapListele()
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM kitap";// Listelemesi gereken sorgu oluşturuldu.

            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            return dt;
        }
        public void kitapEkle(int txtISBN, string txtAd, string mtxtYayinT, int txtSayfaS,
            string cmbYayinEvi, string cmbYazar, string cmbKategori, int stokSayisi, string rafNo, string ozet)
        {
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = "INSERT INTO kitap(ISBN,kitapAdi,yayinTarihi,sayfaSayisi,yayinEvi,yazar,kategori,stokSayisi,rafNo,ozet) " +
                "VALUES (@ISBN,@kitapAdi,@yayinTarihi,@sayfaSayisi,@yayinEvi,@yazar,@kategori,@stokSayisi,@rafNo,@ozet)";
            cmd.Parameters.AddWithValue("@ISBN", txtISBN);
            cmd.Parameters.AddWithValue("@kitapAdi", txtAd);
            cmd.Parameters.AddWithValue("@yayinTarihi", mtxtYayinT);
            cmd.Parameters.AddWithValue("@sayfaSayisi", txtSayfaS);
            cmd.Parameters.AddWithValue("@yayinEvi", cmbYayinEvi);
            cmd.Parameters.AddWithValue("@yazar", cmbYazar);
            cmd.Parameters.AddWithValue("@kategori", cmbKategori);
            cmd.Parameters.AddWithValue("@stokSayisi", stokSayisi);
            cmd.Parameters.AddWithValue("@rafNo", rafNo);
            cmd.Parameters.AddWithValue("@ozet", ozet);
            cmd.ExecuteNonQuery();
        }
        public void kitapSil(int txtISBN)
        {
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = string.Format("DELETE FROM kitap WHERE ISBN=" + txtISBN + "");
            cmd.ExecuteNonQuery();
        }
        public void kitapGuncelle(int txtISBN, string txtAd, string mtxtYayinT, int txtSayfaS,
            string cmbYayinEvi, string cmbYazar, string cmbKategori, int stokSayisi, string rafNo, string ozet)
        {
            string cmdText = "UPDATE kitap SET kitapAdi='" + txtAd + "', yayinTarihi='" + mtxtYayinT
                + "', sayfaSayisi='" + txtSayfaS + "', yayinEvi='" + cmbYayinEvi + "', yazar='" + cmbYazar + "'" +
                ", kategori='" + cmbKategori + "', stokSayisi='" + stokSayisi + "', rafNo='" + rafNo + "', ozet='" + ozet +
                "' WHERE ISBN=" + txtISBN + "";
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        public string kitapAd, sayfaS, kategori, yazar, yayinE, yayinT, raf, ozet;
        public int stok;
        public void kitapBilgiGetir(int isbn)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM kitap WHERE ISBN=" + isbn + "";// Listelemesi gereken sorgu oluşturuldu.
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kitapAd = dr["kitapAdi"].ToString();
                sayfaS = dr["sayfaSayisi"].ToString();
                kategori = dr["kategori"].ToString();
                yazar = dr["yazar"].ToString();
                yayinE = dr["yayinEvi"].ToString();
                yayinT = dr["yayinTarihi"].ToString();
                raf = dr["rafNo"].ToString();
                ozet = dr["ozet"].ToString();
                stok = Convert.ToInt32(dr["stokSayisi"].ToString());
            }

        }
    }
}
