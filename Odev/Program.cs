using System.Collections.Generic;

namespace Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sonsuz bir döngü içerisnde kullancıya 0 girene kadar sayı sordur
            //kullanıcının girdiği her bir sayıyı bir list<int> tipinde add yapalım.
            //sonra programamızda bir method yazalım ve adına toplam ismini verelim. bu methodumuz dışarıdan paramtre olarak
            //List<int> tipinde bir liste atsın ve amacı bu listenin içerisinde ki tüm sayıların toplamını int olarak geriye döndürmek olsun.
           //bu method kullanıcı 0 girdiğinde sonsuz döngüden çıktığında çalışsın.
           //bir method daha yazalım . bunun da adı tek sayılarıgetir olsun . geriye bir List<int> döndürsün ve parametre olarak da
           //yine List<int> atsın.
           List<int> list = new List<int>();
            int sayi = 0;
            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                list.Add(sayi);
            } while (sayi != 0);
            Console.WriteLine("Sayıların toplam değeri : " + Topla(list));
            List<int> tekSayiler = TekSayilariGetir(list);
            Console.Write("Tek sayılar : "); ;
            foreach (int i in tekSayiler)
                Console.Write(i + "-");
            // TekSayilariGetir(list);

        }
        static int Topla (List<int> liste)
        {
            //int toplam = list.Sum();
            //Console.WriteLine("Sayıların toplam değeri : " + toplam);
            //return list;
            return liste.Sum();
        }
        static List<int> TekSayilariGetir (List<int> list )
        {

            //List<int> tekSayilar = new List<int>();
            //Console.Write("girilen tek sayilar : ");
            //foreach (var sayilar in list)
            //{
            //    if (sayilar % 2 == 1)
            //    {
            //        tekSayilar.Add(sayilar);
            //        Console.Write(sayilar+" ");
            //    }
            //}
            //return tekSayilar;
            return list.Where(i => i %2!= 0).ToList();
        }
    }
}