using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOREACH DÖNGÜSÜ

            //foreach(1;2;3;4)
            //1:değişken türü
            //2:değişken adı
            //3:In
            //4:liste,koleksiyon,dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 78, 985, 635, 74, 11, 22, 33, 41, 205, 65, 78 };
            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }

            //}



            //int[] numbers = { 78, 985, 635, 74, 11, 22, 33, 41, 205, 65, 78 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            //List<int> numbers = new List<int>()
            //{ 
            //    1,2,3,4,5,8 
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = " merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}





            #endregion

            #region ÖRNEK SINAV SİSTEMİ UYGULAMASI

            //Console.Write("***** C# EĞİTİM KAMPI SINAV UYGULAMASI *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("----------------------------");
            //Console.Write("sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------");



            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvarage = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write("lütfen öğrenci ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    Console.WriteLine("----------------------------");


            //    double totalExamResult = 0;


            //    //her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1} sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;//notları topluyoruz
            //    }
            //    studentExamAvarage[i] = totalExamResult / 3;
            //}
            //Console.WriteLine();
            ////sınav ortalaması ve geçip kalma durumu
            //for (int i = 0; i < studentCount; i++)
            //{

            //    Console.WriteLine("----------------------------------------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması:{studentExamAvarage[i]}");


            //    if (studentExamAvarage[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]}adlı öğrenci dersi geçti");

            //    }
            //    else
            //    {
            //        Console.WriteLine("öğrenci başarısız oldu");
            //    }

            //    Console.WriteLine("------------------------------------------------------");
            //}

           


            #endregion
            Console.Read();
        }
    }
}





