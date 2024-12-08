using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_databaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET kullanımı

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Kategoriler");
            Console.WriteLine("2 - Ürünler");
            Console.WriteLine("3 - Siparişler");
            Console.WriteLine("4 - Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");

            // tableNumber değişkenini tanımlayarak kullanıcıdan giriş alıyoruz
            string tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------");

            SqlConnection connection = new SqlConnection("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=egitimKampiDb;Integrated Security=True");
            connection.Open();

            // Veritabanından TblCategory tablosundaki verileri getiriyoruz
            SqlCommand command = new SqlCommand("SELECT * FROM TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            connection.Close();

            // Verileri ekrana yazdırıyoruz
            foreach (DataRow row in datatable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + "\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
