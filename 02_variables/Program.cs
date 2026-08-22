using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Liatesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;


            //Console.WriteLine("1----Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("1----portakalBirim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("1----çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("1----patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("1----domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //tomatoGram = 4.859;
            //potatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim fiyatı: " + applePrice + " - Gramaj: " + appleGram + " -Toplam Tutar: " + appleTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim fiyatı: " + orangePrice + " - Gramaj: " + orangeGram  + " -Toplam Tutar: " + orangeTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " -Toplam Tutar: " + strawberryTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " -Toplam Tutar: " + potatoTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " -Toplam Tutar: " + tomatoTotalPrice + " TL ");

            //Double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");

            #endregion

            #region Char Değişkenler


            //ASCDEFGH
            //DEF...
            //TOPLANTI SAAT 20.00'DE
            //" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);



            #endregion


            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //String passengerName, passengerSurname, passengerDitrict, passengerCity, passengerAge, passengerIdendityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soy Adı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDitrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Bilgisi: ");
            //passengerIdendityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine(" Yolcu Adı Soyadı: " + passengerName + "-" + passengerSurname + "-" + passengerDitrict + "/" + passengerCity + "-" + "Yolcu TC Kimlik No: " + passengerIdendityNumber + " " + "Yolcunun Yaşı: " + passengerAge );






            #endregion

            #region KLAVYEDEN TAM SAYI GİRİŞLERİ VE DÖNÜŞÜMLER

            //ABC12D

            //int shoesPriece, computerPrice, chairPrice, tvPrice;
            //shoesPriece = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12500;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPriece + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);


            #endregion

            #region KLAVYEDEN ONDALIKLI SAYI İŞLEMLERİ


            //double exam1, exam2, exam3, exam4, result;

            //Console.Write("lütfen 1. sınav sonucunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sınav sonuçlarını giriniz: ");
            //exam2= double.Parse(Console.ReadLine());

            //Console.Write("lütfen 3. sınav sonucunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 4. sınav sonuçlarını giriniz: ");
            //exam4 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3 + exam4) / 4;


            //Console.WriteLine("sınav ortalamanız: " + result);

            //ÖNEMLİ NOTT!!!! EKRANDAN ONDALIKLI GİRERKEN VİRGÜL KOYACAKSIN YOKSA TAM KABUL EDER AYIRMAZ.








            #endregion

            #region KLAVYEDEN KARAKTER GİRİŞLERİ
            Char gender;
            Console.Write("Lütfen cinsiyetinizi seçiniz: ");
            gender = char.Parse(Console.ReadLine());


            Console.WriteLine("seçtiğiniz cinsiyet: " + gender);



            #endregion







            Console.Read();

        }
    }
}
