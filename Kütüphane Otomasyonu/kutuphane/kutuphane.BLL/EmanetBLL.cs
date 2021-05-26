using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane.DAL;
using System.Data;

namespace kutuphane.BLL
{
    public class EmanetBLL
    {
        private EmanetDAL emanetDal;
        public EmanetBLL()
        {
            emanetDal = new EmanetDAL();
        }
        public void sepetEkle(int isbn, string kitapad, string yazar, string sayfaS, int kitapS, string teslimT, string iadeT, string sonTeslimT)
        {
            emanetDal.sepetEkle(isbn, kitapad, yazar, sayfaS, kitapS, teslimT, iadeT, sonTeslimT);
        }
        public void sepetSil(int isbn)
        {
            emanetDal.sepetSil(isbn);
        }
        public DataTable sepetListele()
        {
            return emanetDal.sepetListele();
        }
        // Üye bilgilerini getirir.
        public void uyeGetir(string uye)
        {
            emanetDal.uyeGetir(uye);
        }
        public string add
        {
            get { return emanetDal.ad; }
            set { emanetDal.ad = value; }
        }
        public string tell
        {
            get { return emanetDal.tel; }
            set { emanetDal.tel = value; }
        }
        // Kitap bilgilerini getirir.
        public void kitapGetir(string isbn)
        {
            emanetDal.kitapGetir(isbn);
        }
        public string kitapad
        {
            get { return emanetDal.kitapad; }
            set { emanetDal.kitapad = value; }
        }
        public string yazar
        {
            get { return emanetDal.yazar; }
            set { emanetDal.yazar = value; }
        }
        public string sayfaS
        {
            get { return emanetDal.sayfaS; }
            set { emanetDal.sayfaS = value; }
        }
        public void emanetVer(int tc, string adSoyad, string tel, int isbn, string kitapad, string yazar, string sayfaS, int kitapS, string teslimT, string sonTeslimT, string iadeT)
        {
            emanetDal.emanetVer(tc, adSoyad, tel, isbn, kitapad, yazar, sayfaS, kitapS, teslimT, sonTeslimT, iadeT);
        }
        public DataTable iadeListele()
        {
            return emanetDal.iadeListele();
        }
        public DataTable uyeAra(int tc)
        {
            return emanetDal.uyeAra(tc);
        }
        public DataTable kitapAra(int isbn)
        {
            return emanetDal.kitapAra(isbn);
        }
        public void iadeAl(int uyeTc, int kitapIsbn, int kitapS, string iadeT)
        {
            emanetDal.iadeAl(uyeTc, kitapIsbn, kitapS, iadeT);
        }
        public DataTable emanetListele()
        {
            return emanetDal.emanetListele();
        }
        public void uyeBorc()
        {
            emanetDal.uyeBorc();
        }
    }
}
