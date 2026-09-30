using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VOİD METOTLAR
            //()
            // geriye değer döndürmeyen metotlar
            //customer---> listele,ekle ,sil,güncelle


            //void CustemerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayşe yıldız");
            //    Console.WriteLine("Hakan öztürk");
            //    Console.WriteLine("merve çınar");

            //}

            //CustemerList();
            //CustemerList();
            //CustemerList();   dört kere çağırmış olduk bunun şeklinde 16 satır kod yazmak yerine daha hızlı kullanmamıza yaramış oldu.
            //CustemerList();   üzerine geldiğimiz zaman sol alt köşede kilit var bu demekki bu method private method demek. ilerde konuşacağız dedi hoca ama ne zaman bilmiyorum aklıma gelirse geri döner açıklama olarak yazarım.


            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}


            //sum();




            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN STRİNG PARAMETRELİ METOTLAR
            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Mehmet Yıldırım");

            //void customerCard( string name,string SurName)
            //{
            //    Console.WriteLine("Müşteri: " + name+ " " + SurName);
            //}

            //customerCard("mehmet", "yıldız");
            //customerCard("ayşegül", "kaya");

            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN INT PARAMETRELİ METOTLAR

            // void sum(int number1,int number2,int number3)
            //{
            //    int result= number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4,5,6);

            #endregion



            #region GERİYE DEĞER DÖNDÜREN METOTLAR
            //string customerName()
            //{
            //    return " buse yıldız";
            //}
            //customerName();

            //string studentCard()
            //{
            //    string name = "Ali";
            //        string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(studentCard());



            #endregion




            #region GERİYE DEĞER DÖNDÜREN STRING PARAMETRELİ METOTLAR
            // string countryCard(string countryName, string cappital, string flagColor)
            // {
            //     string cardInfo = "ülke: "+ countryName+ " - başkent: "+ cappital + " - bayrak rengi: " + flagColor;
            //     return cardInfo;
            // }

            // string x, y, z;
            // Console.Write("ülke adı giriniz: ");
            // x = Console.ReadLine();

            // Console.Write(" başkenti giriniz: ");
            // y = Console.ReadLine();

            // Console.Write(" bayrak rengi giriniz: ");
            // z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));


            // Console.WriteLine(countryCard("Türkiye", "Ankara", "Kırmızı-Beyaz")); ------> bak burada tanımlamış olduk ve belleğe zaten kaydedilmiş oldu ve bu sayede birden fazla tanımama yapabildik sonucunda ne oldu?--- hem biz veri girdisi verdik hem de karsıdan ver veri girebilmiş olduk.

            #endregion

            #region GERİYE DEĞER DÖNDÜREN INT PARAMETRELİ METOTLAR

            //int sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(44, 36));
            //Console.WriteLine(sum(14, 20));



            #endregion

            #region ÖRNEK UYGULAMA
            //string examResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi " + "ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(examResult("ali", 25, 41, 55));
            //Console.WriteLine(examResult("ayşe", 36, 88, 33));




            #endregion
            Console.Read();
        }

    }
}
