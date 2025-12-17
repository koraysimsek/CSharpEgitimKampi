using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yılmaz");
            //    Console.WriteLine("Ahmet Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = 3;
            //    Console.WriteLine(x + y + z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine(name + " " + surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Murat", "Yücedağ");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int n1, int n2, int n3)
            //{
            //    int result = n1 + n2 + n3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 2, 3);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int n1, int n2)
            //{
            //    int result = n1 + n2;
            //    return result;
            //}

            //Console.WriteLine(Sum(3,6));
            //Console.WriteLine(Sum(6, 63));
            //Console.WriteLine(Sum(19, 62));
            //Console.WriteLine(Sum(33, 61));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " Adlı Öğrenci Sınavı Geçti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " Adlı Öğrenci Başarısız Oldu " + "Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Koray", 70, 60, 45));
            //Console.WriteLine(ExamResult("Murat", 20, 30, 45));

            #endregion

            Console.Read();
        }
    }
}
