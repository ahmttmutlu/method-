using System.Diagnostics.Metrics;

namespace TextDosyasiIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veri yazmak için
            //StreamWriter writer = new StreamWriter("C:\\Users\\ahmet\\OneDrive\\Masaüstü\\test\\deneme.txt",true);
            //string metin = Console.ReadLine();
            //writer.WriteLine(metin);
            //writer.Close();

            //veri okumak için
            //StreamReader reader = new StreamReader("C:\\Users\\ahmet\\OneDrive\\Masaüstü\\test\\deneme.txt");
            //string satir = reader.ReadLine();
            //while(satir != null)
            //{
            //    Console.WriteLine(satir);
            //    satir = reader.ReadLine();
            //}

            //Kullancıya bir öğrenci adı soralım bunu sonsuz bir döngü içinde sroalım . kullanıcı öğrenci ismi yazıp
            //entera bastıkça bunu bir text dosyası içerisine kaydedin
            const string dosyaYolu = "C:\\Users\\ahmet\\OneDrive\\Masaüstü\\test\\deneme.txt";
            while(true)
            {
                Console.WriteLine("Öğrenci ismi giriniz : ");
                string ogrenci = Console.ReadLine();
                Console.WriteLine("Öğrencinin numarasını giriniz : ");
                ogrenci += " " + Console.ReadLine();
                Yaz(dosyaYolu,ogrenci);
            }
        }
        static void Yaz(string dosyaYolu, string metin)
        {
            StreamWriter writer = new StreamWriter(dosyaYolu,true);
                writer.WriteLine(metin);
                writer.Close();
            
        }
    }
}