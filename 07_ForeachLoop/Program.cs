﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //3:Liste,Koleksiyon,Dizi

            //string[] cities = { "ankara", "roma", "budapeşte", "ankara", "istanbul", "varşova" };


            //cities dizisini tek tek dolaşıp değerleri city e atıyor
            //foreach (string city in cities)  
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            //foreach (int number in numbers)
            //{
            //    if (number %2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}









            #endregion

            #region Örnek Sınav Sistemi Uygulaması


            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCout = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCout];
            double[] studentExamAvg = new double[studentCout];

            for (int i = 0; i < studentCout; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // notları topluyoruz.
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }


            //Sınav ortalamaları

            for (int i = 0;i < studentCout;i++)
            {
                Console.WriteLine("----------------------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumlari

                if (studentExamAvg[i] >= 50 )
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }

                Console.WriteLine("----------------------------------------------") ;   
            }




            #endregion
            Console.Read();
        }
    }
}
