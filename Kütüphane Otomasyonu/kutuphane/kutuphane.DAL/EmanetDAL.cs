using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace kutuphane.DAL
{
    public class EmanetDAL
    {
        private DBConnection dBConnection;
        public EmanetDAL()
        {
            dBConnection = new DBConnection(); // Bağlantı sınıfından nesne türetildi. 
            //Aşağıdaki listeleme,ekleme vb durumlarda oluşan değişiklikler için veritabanı ile bağlantısında kullanılacak.
        }
        public void sepetEkle(int isbn, string kitapad, string yazar, string sayfaS, int kitapS, string teslimT, string iadeT, string sonTeslimT)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "INSERT INTO sepet(ISBN,kitapAdi,yazar,sayfaSayisi,kitapSayisi,teslimTarihi,iadeTarihi,sonTeslimTarihi) " +
                    "VALUES (@ISBN,@kitapAdi,@yazar,@sayfaSayisi,@kitapSayisi,@teslimTarihi,@iadeTarihi,@sonTeslimTarihi)";
            // Listelemesi gereken sorgu oluşturuldu.
            cmd.Parameters.AddWithValue("@ISBN", isbn);
            cmd.Parameters.AddWithValue("@kitapAdi", kitapad);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@sayfaSayisi", sayfaS);
            cmd.Parameters.AddWithValue("@kitapSayisi", kitapS);
            cmd.Parameters.AddWithValue("@teslimTarihi", teslimT);
            cmd.Parameters.AddWithValue("@iadeTarihi", iadeT);
            cmd.Parameters.AddWithValue("@sonTeslimTarihi", sonTeslimT);
            cmd.ExecuteNonQuery();
        }
        public void sepetSil(int isbn)
        {
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = string.Format("DELETE FROM sepet WHERE ISBN=" + isbn + "");
            cmd.ExecuteNonQuery();
        }
        public DataTable sepetListele()
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM sepet";// Listelemesi gereken sorgu oluşturuldu.

            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            return dt;
        }
        public string ad, tel;
        public void uyeGetir(string uye)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM uyeler WHERE TCKimlikNo LIKE '" + uye + "'";// Listelemesi gereken sorgu oluşturuldu.
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ad=dr["uyeAdi"].ToString();
                tel=dr["telefon"].ToString();
            }
        }
        public string kitapad, yazar, sayfaS;
        public void kitapGetir(string isbn)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM kitap WHERE ISBN LIKE '" + isbn + "'";// Listelemesi gereken sorgu oluşturuldu.
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kitapad = dr["kitapAdi"].ToString();
                yazar = dr["yazar"].ToString();
                sayfaS = dr["sayfaSayisi"].ToString();
            }
        }
        public void emanetVer(int tc, string adSoyad, string tel, int isbn, string kitapad, string yazar, string sayfaS, int kitapS, string teslimT, string sonTeslimT, string iadeT)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "INSERT INTO emanetKitap(uyeTc,adSoyad,telefon,ISBN,kitapAdi,yazar,sayfaSayisi,kitapSayisi,teslimTarihi,sonTeslimTarihi,iadeTarihi) " +
                    "VALUES (@uyeTc,@adSoyad,@telefon,@ISBN,@kitapAdi,@yazar,@sayfaSayisi,@kitapSayisi,@teslimTarihi,@sonTslimTarihi,@iadeTarihi)";
            cmd.Parameters.AddWithValue("@uyeTc", tc);
            cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
            cmd.Parameters.AddWithValue("@telefon", tel);
            cmd.Parameters.AddWithValue("@ISBN", isbn);
            cmd.Parameters.AddWithValue("@kitapAdi", kitapad);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@sayfaSayisi", sayfaS);
            cmd.Parameters.AddWithValue("@kitapSayisi", kitapS);
            cmd.Parameters.AddWithValue("@teslimTarihi", teslimT);            
            cmd.Parameters.AddWithValue("@sonTeslimTarihi", sonTeslimT);
            cmd.Parameters.AddWithValue("@iadeTarihi", iadeT);
            cmd.ExecuteNonQuery();
            OleDbCommand cmd1 = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd1.CommandText = "UPDATE kitap SET stokSayisi = stokSayisi - " + kitapS + " WHERE ISBN = " + isbn + "";
            cmd1.ExecuteNonQuery();
            OleDbCommand cmd2 = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd2.CommandText = "DELETE FROM sepet";
            cmd2.ExecuteNonQuery();
            OleDbCommand cmd3 = dBConnection.accessCommand();// Komut database ile bağlandı.
            // Bir tabloyu içindekilerle başka tabloya eklemek için gereken sorgu.
            cmd3.CommandText = "INSERT INTO emanet SELECT * FROM emanetKitap";            
            cmd3.ExecuteNonQuery();
        }
        public DataTable iadeListele()
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM emanetKitap";// Listelemesi gereken sorgu oluşturuldu.
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            return dt;
        }
        public DataTable uyeAra(int tc)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM emanetKitap WHERE uyeTc LIKE '%" + tc + "%'";// Listelemesi gereken sorgu oluşturuldu.
            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            return dt;
        }
        public DataTable kitapAra(int isbn)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM emanetKitap WHERE ISBN LIKE '%" + isbn + "%'";// Listelemesi gereken sorgu oluşturuldu.
            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            return dt;
        }
        public void iadeAl(int uyeTc, int kitapIsbn, int kitapS, string iadeT)
        {
            OleDbCommand cmd = dBConnection.accessCommand();
            cmd.CommandText = "UPDATE emanetKitap SET iadeTarihi = '" + iadeT + "' WHERE ISBN = " + kitapIsbn + "AND uyeTc = " + uyeTc + " ";
            cmd.ExecuteNonQuery();

            OleDbCommand cmd1 = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd1.CommandText = "DELETE FROM emanetKitap WHERE uyeTc=@uyeTc AND ISBN=@ISBN";
            cmd1.Parameters.AddWithValue("@uyeTc", uyeTc);
            cmd1.Parameters.AddWithValue("@ISBN", kitapIsbn);
            cmd1.ExecuteNonQuery();

            OleDbCommand cmd2 = dBConnection.accessCommand();
            cmd2.CommandText = "UPDATE kitap SET stokSayisi = stokSayisi + " + kitapS + " WHERE ISBN = " + kitapIsbn + "";
            cmd2.ExecuteNonQuery();

            OleDbCommand cmd3 = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd3.CommandText = "UPDATE emanet SET iadeTarihi = '" + iadeT + "' WHERE ISBN = " + kitapIsbn + "AND uyeTc = " + uyeTc + " ";
            cmd3.ExecuteNonQuery();
        }
        public DataTable emanetListele()
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM emanet";// Listelemesi gereken sorgu oluşturuldu.
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            return dt;            
        }
        public void uyeBorc()
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT * FROM emanet";// Listelemesi gereken sorgu oluşturuldu.
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable(); // Tablo üzerinden veriler listelenicek.
            dt.Load(cmd.ExecuteReader()); // Okunur ve listelenir.
            DateTime sonTeslim, iadeT;
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int sayac = 0; // Kitabı geç teslim eden kişiye her geç teslim ettiği gün kadar +1TL borcu tutar.
                // Tarihler datagridviewden alınarak tarih formatına atanır.
                sonTeslim = DateTime.Parse(dt.Rows[i]["sonTeslimTarihi"].ToString());
                iadeT = Convert.ToDateTime(dt.Rows[i]["iadeTarihi"].ToString());
                // İki tarih arasındaki güne göre renk belirleneceği için int(sayı) formatına çevrilerek aşağıda işlem yapılmıştır.
                if (Convert.ToInt32(sonTeslim.Day.ToString()) - Convert.ToInt32(iadeT.Day.ToString()) < 0)
                {
                    int gun = Convert.ToInt32(sonTeslim.Day.ToString()) - Convert.ToInt32(iadeT.Day.ToString());
                    sayac++;
                    OleDbCommand cmd1 = dBConnection.accessCommand();// Komut database ile bağlandı.
                    cmd1.CommandText = "UPDATE uyeler SET borc = borc + '" + sayac * gun + "' WHERE TCKimlikNo = " + dt.Rows[i]["uyeTc"].ToString() + " ";
                    cmd1.ExecuteNonQuery();
                }
            }
        }

    }
}
