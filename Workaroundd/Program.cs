using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaroundd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();
            SelamVer("tugrul");
            SelamVer("tugrul");
            SelamVer("tugrul");
            int sonuc = Topla(5, 6);
            //Diziler / Arrays

            string ogrenci1 = "engin ";
            string ogrenci2 = "tugrul";
            string ogrenci3 = "kerem";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "engin ";
            ogrenciler[1] = "tugrul";
            ogrenciler[2] = "kerem";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehırler1 = new[] { "ankara", "istanbul", "izmir" };

            string[] sehırler2 = new[] { "bursa", "antalya", "dıyarbakır" };
            sehırler2 = sehırler1;
            sehırler1[0] = "adana";
            Console.WriteLine(sehırler2[0]);

            foreach (string sehır in sehırler1 )
            {
                Console.WriteLine(sehır);
            }    
            Person person1 = new Person();
            person1.Firstname = "Engin";
            
            
            Person person2 = new Person();
            person2.Firstname = "Murat";
            
            
            List<string> yenısehırler1 = new List<string>{"ankara1","istanbul1", "izmir1"};
            yenısehırler1.Add(item:"adana1");
            foreach (var sehır in yenısehırler1)
            {
                Console.WriteLine(sehır);
            }
            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);
             
        }

        static void SelamVer(string isim)
        {
            Console.WriteLine( "Merhaba"+ " " +  isim);
        }
        static int Topla(int sayi1 , int sayi2) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam"+" "+ sonuc);

            return sonuc;
        }
        static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000;
            int sayı =  100;
            bool girsYapmismi=false;

            string ad = "Tugrul";
            string soyAd = "sahar";
            int doogumYili = 2004;
            long tcNı = 12346578950;

             
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }



    }
}
