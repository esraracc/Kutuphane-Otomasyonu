using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using kutuphane.DAL;

namespace kutuphane.BLL
{
    public class UyeBLL
    {
        private UyeDAL uyeDal;
        public UyeBLL()
        {
            uyeDal = new UyeDAL();
        }
        public DataTable uyeListele()
        {
            return uyeDal.uyeListele();
        }
        public void uyeEkle(int tcKimlik, string uyeAd, string uyeSoyad, string telefon, string mail, string adres)
        {
            uyeDal.uyeEkle(tcKimlik, uyeAd, uyeSoyad, telefon, mail, adres);
        }
        public void uyeSil(int tcKimlik)
        {
            uyeDal.uyeSil(tcKimlik);
        }
        public void uyeGuncelle(int tcKimlik, string uyeAd, string uyeSoyad, string telefon, string mail, string adres)
        {
            uyeDal.uyeGuncelle(tcKimlik, uyeAd, uyeSoyad, telefon, mail, adres);
        }

    }
}
