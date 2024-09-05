using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp9
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            string str = string.Format("{0},{1},{2},{3},{4}", ProductId, Name, UnitPrice, Quantity, Category);
            return str;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object Initializer
            Product p = new Product();
            List<Product> products = new List<Product>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter product id:");
                int productid=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product name:");
                string productname=Console.ReadLine();
                Console.WriteLine("Enter Unit Price:");
                int unitprice=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter quantity:");
                int quantity= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product category:");
                string category = Console.ReadLine();
                products.Add(new Product() {ProductId=productid,Name=productname,UnitPrice=unitprice,Quantity=quantity,Category=category});
            }
   
        

            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}