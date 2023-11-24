namespace notlarUcuncuHafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        //   -----Sayı tahmin etme oyunu-------------------
            Random random = new Random();
        int sayi = random.Next(1, 100);
        Console.WriteLine("Tahmin edilen sayıyı giriniz");
            while (true) {

                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin<sayi)
            {
                Console.WriteLine("daha büyük sayı giriniz");

            }
            else if (tahmin > sayi)
            {
                Console.WriteLine("daha küçük sayı giriniz");
            }

            else
{

    Console.WriteLine("TAHMİNİNİZ DOĞRU");
    Console.WriteLine($"Random oluşturulan sayı :  {sayi}");
}
            }


        }
    }

    }
