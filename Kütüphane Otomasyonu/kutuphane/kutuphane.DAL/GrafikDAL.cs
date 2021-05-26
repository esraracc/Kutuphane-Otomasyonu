using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ZedGraph;
using System.Drawing;

namespace kutuphane.DAL
{
    public class GrafikDAL
    {
        private DBConnection dBConnection;
        public GrafikDAL()
        {
            dBConnection = new DBConnection(); // Bağlantı sınıfından nesne türetildi. 
            //Aşağıdaki listeleme,ekleme vb durumlarda oluşan değişiklikler için veritabanı ile bağlantısında kullanılacak. 
        }
        public string tumK, emanetVerilen, emanetVerilmeyen;
        public void zedgraph(ZedGraphControl zedGraph)
        {
            OleDbCommand cmd = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd.CommandText = "SELECT SUM(stokSayisi) FROM kitap";// Sorgu oluşturuldu.
            cmd.ExecuteNonQuery();
            OleDbCommand cmd1 = dBConnection.accessCommand();// Komut database ile bağlandı.
            cmd1.CommandText = "SELECT SUM(kitapSayisi) FROM emanetKitap";// Sorgu oluşturuldu.
            cmd1.ExecuteNonQuery();

            GraphPane myPane = zedGraph.GraphPane;

            // Grafik başlığını yazıyoruz.
            myPane.Title.Text = "KÜTÜPHANEMİZDEKİ KİTAPLARIN BİLGİSİ";
            myPane.Title.IsVisible = true;

            // Kitapların kaçar adet olduğunu hesaplar.
            int kmt = Convert.ToInt32(cmd.ExecuteScalar());
            int kmt1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
            int kmt2 = Convert.ToInt32(cmd.ExecuteScalar()) - Convert.ToInt32(cmd1.ExecuteNonQuery());

            // Kitapların sayısı,renkleri ve isimlendirme ayarları yapılır.
            PieItem pieSlice = myPane.AddPieSlice(kmt, Color.Blue, 0F, "Tüm Kitaplar");
            PieItem pieSlice1 = myPane.AddPieSlice(kmt1, Color.Yellow, 0F, "Emanet Verilenler");
            PieItem pieSlice2 = myPane.AddPieSlice(kmt2, Color.Red, 0F, "Emanet Verilmeye Hazır Olanlar");
            pieSlice.LabelType = PieLabelType.None;
            pieSlice1.LabelType = PieLabelType.None;
            pieSlice2.LabelType = PieLabelType.None;
            
            // Kitapların sayıları labele yazdırılır.
            tumK = "Tüm Kitapların Sayısı: " + kmt + " ";
            emanetVerilen = "Emanet Verilen Kitapların Sayısı: " + kmt1 + " ";
            emanetVerilmeyen = "Emanet Verilmeye Hazır Kitapların Sayısı: " + kmt2 + " ";

            // Grafik göstergesinde etiket istememe ayarı
            myPane.Legend.IsVisible = true;
            myPane.Legend.Position = ZedGraph.LegendPos.Right;

            // Uzaklaştırma ve yakınlaştırma işlemi aşağıdaki gibi yapılır. Adım aralığı belirlenir. 
            //Fakat pasta grafiği olduğundan bu işlem gerçekleşmiyor.
            
        }

    }
}

