using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //Aynı veri tipinde ki çok sayıda veriyi bir arada tutar
            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);


            //tam sayı formatında dizi de indexe atama yapmazsan default olarak 0 gelir
            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]);


            //Dizilerin farklı oluşturma şekli
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);


            #endregion


            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 1,2,3,4,5,6,7,8,9 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] chars = { 'a', 'b', 'c', '*', '-' };
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            #endregion

            #region Dizideki en büyük elemanı bulan

            //int[] myArray = { 24, 14, 55, 73, 799, 243, 85, 23 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi metodları


            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 645, 321, 67, 77, 324, 83, 35, 67, 34, 29 };
            //Array.Sort(numbers); //diziyi küçükten büyüğe doğru sırala
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 645, 321, 67, 77, 324, 83, 35, 67, 34, 29 };
            //Array.Reverse(numbers); //diziyi tersten sıralıyo
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve"); //merve kaçıncı indexte
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //Console.WriteLine("Dizinin en büyük elemanı : " +numbers.Max()+ " | " + "Dizinin en küçük elemanı : " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    //dolar sembolü sayesinden çift tırnak içinde parametresel ifadeler kullanmamızı sağlar
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = new int[4];
            //int sum = 0;

            //for (int i = 0; i<numbers.Length ; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. sayıyı giriniz :");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0;i<numbers.Length ; i++)
            //{
            //    sum += numbers[i];

            //}

            //Console.WriteLine("Sayıların toplamı = " + sum);






            #endregion

            #region Dizideki sayıları tek çift olarak ayırma

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();

        }
    }
}
