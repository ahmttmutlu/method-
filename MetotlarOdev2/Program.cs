namespace MetotlarOdev2
{
    internal class Program
    {
       static List<string> ogrenciler { get; set; } = new List<string>();
       static bool ilkSeferMi { get; set; }
        static void Main(string[] args)
        {
            
            while (true)
            {
                
                int secim = MenuYazdir();

                if (secim == 1)
                {
                    OgrenciEkle();
                }
                else if (secim == 2)
                {
                    OgrenciListele();
                }
                else if (secim == 3)
                {
                    OgrenciDuzenle();
                }
                else if (secim == 4)
                {
                    OgrenciSil();
                }
                else if (secim == 5)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış bir seçim girdiniz");
                }

            }
        }
        static int MenuYazdir()
        {
            if (ilkSeferMi)
            {
                ilkSeferMi = false;
            }
            else
            {
                Thread.Sleep(2000);
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.Beep();
            Console.WriteLine("### MENU ###");
            Console.WriteLine("1 - Öğrenci ekle");
            Console.WriteLine("2 - Öğrenci listele");
            Console.WriteLine("3 - Öğrenci düzenle");
            Console.WriteLine("4 - Öğrenci sil");
            Console.WriteLine("5 - Çıkış");

            return Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
        }
        static void OgrenciEkle()
        {
            Console.Write("\nöğrenci ismi giriniz :");
            string Ogrenci = Console.ReadLine();
            ogrenciler.Add(Ogrenci);
            Console.WriteLine("Öğrenci başarılı ile eklendi");
          
        }
        static void OgrenciListele()
        {
            Console.WriteLine();
            foreach(string Ogrenci in ogrenciler) 
            { Console.WriteLine(Ogrenci); }
          
        }
        static void OgrenciDuzenle()
        {
            Console.Write("\nÖğrenci adı giriniz: ");
            string ogrenciAdi = Console.ReadLine();
            if (ogrenciler.Contains(ogrenciAdi))
            {
                ogrenciler.Remove(ogrenciAdi);
                Console.Write("Yeni öğrenci adını giriniz: ");
                string yeniAd = Console.ReadLine();
                ogrenciler.Add(yeniAd);
                Console.WriteLine("Öğrenci adı güncellendi.");
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci mevcut değil.");
            }
        }
        static void OgrenciSil()
        {
            Console.Write("\nÖğrenci adı giriniz: ");
            string ogrenciAdi = Console.ReadLine();
            if (ogrenciler.Contains(ogrenciAdi))
            {
                ogrenciler.Remove(ogrenciAdi);
                Console.WriteLine("Öğrenci silindi.");
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci mevcut değil.");
            }
        }

       
    }
}