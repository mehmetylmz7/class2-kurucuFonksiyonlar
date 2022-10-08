using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar2_kurucuFonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan("Ayşe", "Bagriyanik", 1928374, "Muhasebe");
       

            calisan1.CalisanBilgileri();

            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.SoyAd = "Arda";
            calisan2.No = 256879;
            calisan2.Departman = "Insan Kaynaklari";

            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("zikriye", "urkmez");
            calisan3.CalisanBilgileri();



            Console.ReadLine();

        }

    }

    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public Calisan (string ad , string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.SoyAd = soyad;
        }

            public Calisan() {}


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:" + Ad);
            Console.WriteLine("Çalışan Soyadı:" + SoyAd);
            Console.WriteLine("Çalışan Numarası:" + No);
            Console.WriteLine("Çalışanın Departmanı: " + Departman);
        }
    }
}



