﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud --> Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-30R7DGE\\SQLEXPRESS; initial catalog=EgitimKampiDB;integrated security = true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);

            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.Write("Kategori Başarıyla Eklendi");

            #endregion


            #region Ürün Ekleme İşlemi

            // string productName;
            // decimal productPrice;
            // //bool productStatus;

            // Console.Write("Ürün adı: ");
            // productName = Console.ReadLine();

            // Console.Write("Ürün fiyatı: ");
            // productPrice = decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data source = DESKTOP-30R7DGE\\SQLEXPRESS; initial catalog = EgitimKampiDB ; integrated security = true");
            // connection.Open();

            // SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus",true);

            //command.ExecuteNonQuery();
            // connection.Close();

            // Console.Write("Ürün Eklemesi Başarılı");


            #endregion


            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-30R7DGE\\SQLEXPRESS;initial Catalog =EgitimKampiDB;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);

            ////sql verilerini c# tarafına çeken köprü görevini görür
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            ////Verileri geçici hafizaya alabilmek için kullanılan kod (ram de tutulur)
            //DataTable dataTable = new DataTable();

            ////dataTable dan gelen değerle içini doldurjj
            //adapter.Fill(dataTable);


            ////
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+ " "); 
            //    }
            //    Console.WriteLine();    
            //}


            //connection.Close(); 



            #endregion


            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-30R7DGE\\SQLEXPRESS;initial Catalog =EgitimKampiDB;integrated security = true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı");

            #endregion


            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürün ıd : ");
            //int productId =int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı : ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-30R7DGE\\SQLEXPRESS;initial Catalog =EgitimKampiDB;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId = @productId",connection);
            //command.Parameters.AddWithValue("productName",productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");

            #endregion


            Console.Read();  
        }
    }
}
