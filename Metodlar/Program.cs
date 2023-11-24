using System.ComponentModel;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        //METOD - FONKSİYON
        {
            //int sayi = 0;
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //SayilariYazdir(sayi);
            //SayilariYazdir(); 
            List<string> list = new List<string>();
            list.Add("Ahmet");
            list.Add("Mehmet");
            list.Add("Alper");
            list.Add("Merve");
            List<string> filtrelenmisList= IleBaslayanlariGetir(list, "C");
            foreach(string str in filtrelenmisList)
                Console.WriteLine(str);
        
        }
        // dışarıdan 1 tane int tipinde paramtre alan ve geriye bir şey döndürmeyen yani return etmeyen method tanımlaması.
       
        static List<string> IleBaslayanlariGetir(List<string> liste, string harf)
        /* dışarıdan parametre olarak bir list<string> tipinde bir liste alan ve bu aldığı liste içerisinde ki  baş harfi A ile 
       başlayan kayıtları süzüp , sadece onları tekrar bir List<string> olarak geriye döndüren bir metot yazın.*/
        //modifiye edelim ve dışarıdan hangi harfe göre filtreleneceğini dışaırdan biz söyleyelim
        
        {
            if (liste!=null && liste.Count!=0)
            {
                return liste.Where(s => s.StartsWith(harf)).ToList();
            }
            else
            {
                Console.WriteLine("Boş bir liste gönderdiniz");
                return new List<string>();
            }
        }



        static void SayilariYazdir(int x)
        {
            for (int i = 1; i <=x; i++)
            {
                Console.Write(i + "\t");
            }
        }
        static void SayilariYazdir()
        {
             
        // geri dönüş değeri olmayan , yani hiçbir şey return etmeyen ve dışarıdan parametre almayan metod tanımlaması
          int sayi = 0;
          Console.WriteLine("Lütfen bir sayı giriniz");
          sayi =    Convert.ToInt32(Console.ReadLine());
          for (int i = 1; i <= sayi; i++)
            {
                Console.Write(i+ "\t");
            }
        }

    }
}