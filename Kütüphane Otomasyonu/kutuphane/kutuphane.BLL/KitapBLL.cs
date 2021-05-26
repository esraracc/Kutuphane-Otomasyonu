using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane.DAL;
using System.Data;

namespace kutuphane.BLL
{
    public class KitapBLL
    {
        private KitapDAL kitapDal;
        public KitapBLL()
        {
            kitapDal = new KitapDAL();
        }
        public DataTable kitapListele()
        {
            return kitapDal.kitapListele();
        }
        public void kitapEkle(int txtISBN, string txtAd, string mtxtYayinT, int txtSayfaS,
            string cmbYayinEvi, string cmbYazar, string cmbKategori, int stokSayisi, string rafNo, string ozet)
        {
            kitapDal.kitapEkle(txtISBN, txtAd, mtxtYayinT, txtSayfaS, cmbYayinEvi, cmbYazar, cmbKategori, stokSayisi, rafNo, ozet);
        }
        public void kitapSil(int txtISBN)
        {
            kitapDal.kitapSil(txtISBN);
        }
        public void kitapGuncelle(int txtISBN, string txtAd, string mtxtYayinT, int txtSayfaS,
            string cmbYayinEvi, string cmbYazar, string cmbKategori, int stokSayisi, string rafNo, string ozet)
        {
            kitapDal.kitapGuncelle(txtISBN, txtAd, mtxtYayinT, txtSayfaS, cmbYayinEvi, cmbYazar, cmbKategori, stokSayisi, rafNo, ozet);
        }
        // Kitap Bilgileri getirme
        public void kitapBilgiGetir(int isbn)
        {
            kitapDal.kitapBilgiGetir(isbn);
        }
        public string kitapAd
        {
            get { return kitapDal.kitapAd; }
            set { kitapDal.kitapAd = value; }
        }
        public string sayfaS
        {
            get { return kitapDal.sayfaS; }
            set { kitapDal.sayfaS = value; }
        }
        public string kategori
        {
            get { return kitapDal.kategori; }
            set { kitapDal.kategori = value; }
        }
        public string yazar
        {
            get { return kitapDal.yazar; }
            set { kitapDal.yazar = value; }
        }
        public string yayinE
        {
            get { return kitapDal.yayinE; }
            set { kitapDal.yayinE = value; }
        }
        public string yayinT
        {
            get { return kitapDal.yayinT; }
            set { kitapDal.yayinT = value; }
        }
        public string raf
        {
            get { return kitapDal.raf; }
            set { kitapDal.raf = value; }
        }
        public string ozet
        {
            get { return kitapDal.ozet; }
            set { kitapDal.ozet = value; }
        }
        public int stok
        {
            get { return kitapDal.stok; }
            set { kitapDal.stok = value; }
        }
    }
}
