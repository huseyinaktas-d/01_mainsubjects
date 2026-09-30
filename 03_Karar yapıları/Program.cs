using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Karar_yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İF ELSE

            // Console.Write("Lütfen şifrenizi giriniz: ");
            // string password;
            // password = Console.ReadLine();
            // if (password == "abcd")
            // {

            //      Console.WriteLine("Şifre Doğru");
            //}
            // else
            // { 
            //     Console.WriteLine("Şifre Yanlış");



            // }

            //string capital, country;

            //Console.Write("başkenti giriniz: ");
            //capital= Console.ReadLine();

            //Console.Write("ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara"& country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");

            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");

            //}


            //int sayı;
            //Console.Write("sayı giriniz: ");
            //sayı= int.Parse(Console.ReadLine());
            //if(sayı==5 )
            //{
            //    Console.WriteLine("sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("sayıyı yanlış girdiniz");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result = "hata";

            //Console.Write("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());
            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması: " + avarage);


            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (avarage > 84 & avarage <= 100)
            //{
            //    result = "sonuç çok iyi";

            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "trabzon" | city == "bursa")
            //{
            //    Console.WriteLine("şehir mehcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil"); 
            //}



            //Console.Write("lütfen kullanıcı adınızı giriniz: ");
            //string username = Console.ReadLine();

            //if(username !="admin" )
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");

            //}
            //else
            //{
            //    Console.Write("hoş geldiniz");
            //}
            #endregion

            #region MOD ALMA İLEMLERİ


            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);



            //Console.Write("lütfen 1. sayıyı giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("lütfen 1. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " + result);


            //Console.Write("lütfen bir sayı giriniz: ");
            //int number= int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}


            #endregion


            #region CHAR DEĞİİŞKENLERİ İLE KARAR ALMA

            //char team;
            //Console.Write("lütfen takım sembolü giriniz");
            //team= char.Parse(Console.ReadLine());


            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("fener bahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("beşiktaş");
            //}

            #endregion

            #region ÖRNEK PROJE UYGULAMASI


            //Console.WriteLine("****** csharp eğitim kampı restoran *******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("1-ANA YEMEKLER");
            //Console.WriteLine("2-CORBALAR");
            //Console.WriteLine("3-PİZZALAR");
            //Console.WriteLine("4-İÇECEKLER");
            //Console.WriteLine("5-TATLILAR");

            //string menuItem;
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------");



            //Console.Write("detayını görmek istediğiniz menü seçiniz: ");
            //menuItem = Console.ReadLine();

            //    if (menuItem == "1")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("***********ANA YEMEKLER***********");
            //    Console.WriteLine("1-KÖRİ SOSLU TAVUK");
            //    Console.WriteLine("2-KIZARTMA TABAĞI)");
            //    Console.WriteLine("3-FASULYE PİLAV)");
            //    Console.WriteLine("4-FIRINDA SOMON)");
            //    Console.WriteLine("5-PATLICAN MUSAKKA)");
            //    Console.WriteLine();
            //    Console.WriteLine("***********ANA YEMEKLER***********");
            //}

            //    if (menuItem == "2")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("***********ÇORBALAR***********");
            //        Console.WriteLine();
            //        Console.WriteLine("1-MERCİMEK CORBASI");
            //        Console.WriteLine("2-EZOGELİN ÇORBASI)");
            //        Console.WriteLine("3-KELLE PAÇA ÇORBASI)");
            //        Console.WriteLine();
            //        Console.WriteLine("***********ÇORBALAR***********");
            //    }

            //    if (menuItem == "3")
            //    {

            //        Console.WriteLine();
            //        Console.WriteLine("***********PİZZALAR***********");
            //        Console.WriteLine();
            //        Console.WriteLine("1-AKDENİZ PİZZA");
            //        Console.WriteLine("2-MARGARİTA TABAĞI)");
            //        Console.WriteLine("3- TAVUKLU PİZZA)");
            //        Console.WriteLine();
            //        Console.WriteLine("***********PİZZALAR***********");
            //    }

            //    if (menuItem == "4")
            //    {

            //        Console.WriteLine();
            //        Console.WriteLine("***********İÇECEKLER***********");
            //        Console.WriteLine();
            //        Console.WriteLine("1-KOLA");
            //        Console.WriteLine("2-AYRAN)");
            //        Console.WriteLine("3-SARI KOLA)");
            //        Console.WriteLine("4- NİĞDE GAZOZ)");
            //        Console.WriteLine("5-ULUDAĞ MAVİ ŞİŞE SU)");
            //        Console.WriteLine("***********İÇECEKLER***********");
            //    }

            //    if (menuItem == "5")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("***********TATLILAR***********");
            //        Console.WriteLine();
            //        Console.WriteLine("1-ŞÖBİYET");
            //        Console.WriteLine("2-BAKLAVA)");
            //        Console.WriteLine("3-KAZANDİBİ");
            //        Console.WriteLine("4-SÜTLAÇ)");
            //        Console.WriteLine("5-GÜLLAÇ)");
            //        Console.WriteLine();
            //        Console.WriteLine("***********TATLILAR***********");

            //    }











            #endregion

            #region SWİTCH CASE

            //Console.Write("lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("ocak"); break;
            //    case 2: Console.WriteLine("şubat"); break;
            //    case 3: Console.WriteLine("mart"); break;
            //    case 4: Console.WriteLine("nisan"); break;
            //    case 5: Console.WriteLine("mayıs"); break;
            //    case 6: Console.WriteLine("haziran"); break;
            //    case 7: Console.WriteLine("temmuz"); break;
            //    case 8: Console.WriteLine("ağustos"); break;
            //    case 9: Console.WriteLine("eylül"); break;
            //    case 10: Console.WriteLine("ekim"); break;
            //    case 11: Console.WriteLine("kasım"); break;
            //    case 12: Console.WriteLine("aralık"); break;
            //    default:Console.Write("hatalı veri girişi");break;
            //}




            #endregion

            #region SWİTCH CASE HESAP MAKİNESİ

            int number1, number2, result;
            char symbol;

            Console.Write("1. sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("toplam: " + result); break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("fark: " + result); break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("bölüm: " + result); break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("çarpım: " + result); break;

            }





            #endregion

            Console.Read();












        }











    }




}


