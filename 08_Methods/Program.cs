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

            // () ile biter
            // Geriye değer döndürmeyen metotlar
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız..");
            //    Console.WriteLine("Ayşe Yıldız..");
            //    Console.WriteLine("Hakan Öztürk..");
            //    Console.WriteLine("Merve Çınar..");
            //}

            //CustomerList(); // çalışması için çağırmamız gerekiyor
            //CustomerList();
            //CustomerList();
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

            #region Geriye değer döndürmeyen string parametreli metotlar


            //void WriteMothod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMothod("cem");



            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surname);
            //}
            //CustomerCard("Mehmet","Yıldırım");



            #endregion

            #region Geriye değer döndürmeyen ınt parametreli metotlar

            //void sum (int number1, int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(10,20,30);
            #endregion

            #region Geriye değer döndüren metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion


            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName,string capital,string flagColor) 
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.Write(CountryCard(x, y, z));


            #endregion


            Console.Read();
        }
    }
}
