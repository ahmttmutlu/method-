namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers[0] = 7;
            //numbers[1] = 9;
            //     numbers[2] = 3; mevcut senaryoda 2. indeks oluşmadığı için herhangi bir atama olmadı 
            //   numbers[3] = 4;


            //List<string> strings = new List<string>();
            //strings.Add("ahmet");
            //strings.AddRange(new string[] { "emre", "ahmet", "mehmet" });
            //Console.WriteLine(numbers[0]);
            //List<int[]> ints = new List<int[]>();
            //ints.Add(new int[] { 1, 2, 3, 4 });
            //ints.Add(new int[] { 5,6,7,8});
            //ints.Add(new int[] { 9,10,11,12});

            //List<List<List<int>>> list = new List<List<List<int>>>();

            //List<string> ogrenciler = new List<string>();
            //ogrenciler.Add("Emre Özçelikel");
            //ogrenciler.Add("Ahmet Çelebi");
            //ogrenciler.Add("Turan Kaya");

            //foreach (string s in ogrenciler)
            //    Console.WriteLine(s);

            //for (int i = 0; i < ogrenciler.Count; i++) //forlu hali
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}
            //List<int> sayilar = new List<int>();
            //sayilar.AddRange(new int[] { 9, 4, 1, 5, 18, 21, 0, 2 });
            //sayilar.Sort();

            //Console.WriteLine("isim ve soyisim giriniz");
            //string isim = Console.ReadLine();
            //string isimtersten = "";

            //for (int i = isim.Length-1;i>=0;i--)
            //{
            //    isimtersten += isim[i];
            //    Console.Write(isim[i]);
            //}

            //Console.WriteLine("isminizi giriniz");
            //string adSoyad = Console.ReadLine();

            //char[] adSoyadtersten = adSoyad.Reverse().ToArray();
            //foreach (char c in adSoyadtersten)
            //{
            //    Console.Write(c);
            //}

            //List<string> names = new List<string>();
            //names.Add("Emre");
            //names.Add("Ahmet");
            //names.Add("Mehmet");
            //names.Add("Turan");
            //names.Add("Kaya");
            //names.Add("Cengiz");
            //names.Add("Emir");
            //names.Add("Emrah");

            //List<string> eIleBaslayanlar = names.Where(x => x.StartsWith("E")).ToList();

            //List<string> tIleBitenler = names.Where(name => name.EndsWith("t")).ToList();

            //List<string> aIcerenler= names.Where(name => name.Contains("ay")).ToList();

            //foreach (string name in names)
            //{
            //    if(name[name.Length - 1]=='t')
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            //foreach (string name in names)
            //{
            //    if(name.StartsWith("E"))
            //        eIleBaslayanlar.Add(name);
            //}
            //--------------------------------------
            //List<int> sayilar = new List<int>();
            //Random random = new Random();
            //for (int i = 0; i < 50; i++)
            //{
            //   int rastgeleSayi = random.Next(1,1000);
            //   sayilar.Add(rastgeleSayi);
            //}
            //  sayilar = sayilar.Where(s => s > 500).ToList();


            //foreach (int sayi in sayilar)
            //{
            //    if (sayi > 500)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}
            //--------------------------------------------
            List<int> list = new List<int>();
            while (true)
            {
                
                Console.WriteLine("bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {
                    break; 
                }
                list.Add(sayi);


            }
            Console.WriteLine("Toplam girilen sayı adedi : "+list.Count);
           
            
            //int toplam = 0;
            //foreach (int sayi in list)
            //{
            //    toplam += sayi;
            //}
            int toplam = list.Sum();
            Console.WriteLine("Sayıların toplam değeri : "+toplam);

            
            double ortalama = (double)toplam / list.Count;
            Console.WriteLine("Sayıların ortalama değeri : " + ortalama);

            int enBuyukSayi = 0;
            foreach (int i in list)
            {
                if(i > enBuyukSayi)
                {
                    enBuyukSayi = i; 
                }
            }
            Console.WriteLine("Girilen en büyük sayı : " + enBuyukSayi);

            //int enKucukSayi = int.MaxValue;
            //foreach (int i in list)
            //{
            //    if (i < enKucukSayi)
            //    {
            //        enKucukSayi = i;
            //    }
            //}
            Console.WriteLine("Girilen en küçük sayı : "+list.Min());


        }
    }
}