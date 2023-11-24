namespace Siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.Id= 1;
            araba.Marka = "Vosvos";
            araba.TekerlekSayisi = 4;
            araba.Renk = "Kırmıız";
            araba.ModelYili = 1974;
            araba.YolcuAdedi = 3;

           

            Otobus otobus = new Otobus();
            otobus.Id = 2;
            otobus.Marka = "Mercedes";
            otobus.Renk = "Kırmızı";
            otobus.AyaktaYolcuAdedi = 5;
            otobus.EngelliRampasi = true;
            otobus.ModelYili = 2023;
            otobus.YolcuAdedi = 50;
          

            //ALTERNATİF
            Araba araba1 = new Araba { Id = 1 , Marka="BMW", Renk="Kırmızı", TekerlekSayisi=4, ModelYili=1990, YolcuAdedi=3};

            

            //List<Araba> list = new List<Araba>();
            //list.Add(araba);
        
        }
    }
   
}