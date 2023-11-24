namespace TextDosyasiIslemleriOdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*kullanıcdan yine sonsuz döngü içerisinde bir öğrenci isimleri alalım
             bu isimleri öğrenciler.txt isminde bir dosyaya kaydedelim
            bu kayıt işlemeni bir method vasıtası ile yapalım
            ardından sırala isminde bir method daha oluşturalım o da dışarıdan bir tane "dosyayolu" atsın ve
            aldığı dosyanın içerisindeki bütün verileri A dan Z ye sıralasın ve text dosyasının güncellesin*/
            const string dosyaYolu = "C:\\Users\\ahmet\\OneDrive\\Masaüstü\\test\\ogrenciler.txt";
            while (true)
            {
                Console.WriteLine("Öğrenci ismi giriniz : ");
                string ad = Console.ReadLine();
                
                if (ad == "")
                    break;
                Kaydet(dosyaYolu, ad);
            }
            Sirala(dosyaYolu);

        }
        static void Kaydet(string dosyaYolu, string metin)
        {
            //burada bize gönderilen dosyaYolunda ki txt dosyasına gönderilen "metin" parametresinde ne yazıyorsa onu append edeceğiz
            StreamWriter writer = new StreamWriter(dosyaYolu, true);
            writer.WriteLine(metin);
            writer.Close();
        }
        static void Sirala(string dosyaYolu)
        {
            //burada gönderilen dosya yolundaki txt dosyasının içerisindeki tüm satırları a dan z ye sıralı hale getireceğiz
            List<string> list = new List<string>();
            StreamReader reader = new StreamReader(dosyaYolu);
            string line=reader.ReadLine();
            while (line != null)
            {
                list.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();
            list.Sort();
            List<string> deneme = list.Select(s => s+" - "+s.Length).OrderBy(s => s.Length).ToList();

            StreamWriter writer = new StreamWriter(dosyaYolu);
            foreach(string s in list)
                writer.WriteLine(s);
            writer.Close();
        }
    }
}