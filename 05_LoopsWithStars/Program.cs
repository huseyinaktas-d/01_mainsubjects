using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ALT ALTA 10 TANE YILDIZ OLUŞTURMA

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region DİK ÜÇGEN

            //for(int i=1; i<=5; i++)
            //{
            //    for (int j =1;j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region TERS DİK ÜÇGGEN

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region DİK VE TERS ÜÇGEN BERARER

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region BAKLAVA DİLİMİ

            //üst kısım

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////alt kısım

            //for (int i = n - 1; i >= 1; i--)
            //{

            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();


            //}




            #endregion

            #region PİRAMİT 

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region TERS PİRAMİT

            int n = 5;

            //for(int i = n; i >= 1; i--)
            //{
            //   //boşluklar
            //    for(int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //   //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            


            #endregion



            Console.Read();


        }
    }
}
