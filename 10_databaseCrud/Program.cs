using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace _10_databaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud-->create-read-update-delete
            Console.WriteLine("*****Menü Sipariş İşlem Paneli*****");
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            #region Kategori ekleme işlemi
            //Console.WriteLine("Eklemek İstediğiniz Kategori Adı:");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;initial catalog=egitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory(categoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("kategori başarıyla eklendi");
            #endregion

            #region ürün ekleme işlemi
            string ProductName;
            decimal ProductPrice;
            //bool ProductStatus;

            //Console.Write("Ürün adı: ");
            //ProductName=Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //ProductPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;initial catalog=egitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values(@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", ProductName);
            //command.Parameters.AddWithValue("@p2", ProductPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("ürün eklemesi başarılı");
            #endregion

            #region ürün listeleme işlemi
            //SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;initial catalog=egitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region ürün silme işlemi
            Console.Write("silinecek ürün id:");
            int ProductId=int.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;initial catalog=egitimKampiDb;integrated security=true");
            
            connection.Open();
            
            SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productId", ProductId);
            command.ExecuteNonQuery();



            connection.Close();
            Console.WriteLine("silme işlemi yapıldı");

            #endregion

            Console.Read();

        }
    }
}
