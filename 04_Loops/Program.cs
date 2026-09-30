using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR DÖNGÜSÜ

            //for (x; Y; z; )
            //x: başlangıç değeri
            //y: bitiş
            //z: artış-azalış


            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("c# eğitim kampı");
            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //} ;

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lütfen ekrana yazılmasını istedğiniz sayı adetini giriniz: ");
            //int finishvalue= int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion


            #region FOR DÖNGÜSÜ İLE KARAR YAPILARI

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine( i );
            //    }
            //}


            //int totalvalue = 0;
            //for (int i = 1;i<=10;i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine(totalvalue);


            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);



            //1-2-4-8...
            // VİZE SORUSU OLABİLİR

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda: " + bacterium);

            //}


            #endregion

            #region WHİLE DÖNGÜSÜ

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("MERHABA DÖNGÜLER");
            //    i++;
            //}



            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;

            //}       

            //Console.WriteLine(sum);
            #endregion



            #region ÖRNEK SINAV SORUSU

            //Console.Write("sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100;  //4,56--->4(int ile çalıştığımız için virgülden sonrasını atar)
            //tens = (number % 100) / 10;

            //sum = ones + tens + hundreds;

            //Console.WriteLine("Rakamların toplamı: " + sum);

            #endregion





            
        }
    }
}
