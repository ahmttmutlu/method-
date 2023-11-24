// See https://aka.ms/new-console-template for more information
//int enBuyukSayi = 0;
//Console.WriteLine("lütfen 1. sayıyı giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());
//enBuyukSayi = sayi1;

//Console.WriteLine("lütfen 2. sayıyı giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//if (sayi2 > enBuyukSayi)
//{
//    enBuyukSayi = sayi2;
//}
//Console.WriteLine("lütfen 3. sayıyı giriniz");
//int sayi3 = Convert.ToInt32(Console.ReadLine());
//if ( sayi3>enBuyukSayi)
//{
//    enBuyukSayi= sayi3;
//}

//Console.WriteLine($"En büyük sayı : {enBuyukSayi}");


Console.WriteLine("Kaç elemanlı biri dizi oluşturmak istiyorsunuz ?");
int diziDegeri = Convert.ToInt32(Console.ReadLine());

int[] elemanSayisi = new int[diziDegeri];

Random random = new Random();
for (int i = 0; i < diziDegeri; i++)
{
    elemanSayisi[i] = random.Next(1000, 9999);
}

int enBuyukSayi = 0;
for (int i = 0; i < diziDegeri; i++)
{
    if (elemanSayisi[i] > enBuyukSayi)
    {
        enBuyukSayi = elemanSayisi[i];
    }
}
Console.Write("Random oluşturulan sayılar :  ");
foreach (var sayilar in elemanSayisi)
{       
    Console.Write(" "+sayilar);
}
Console.WriteLine();
Console.WriteLine($"En büyük sayı: {enBuyukSayi}");