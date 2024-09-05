using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=USHYDRTANISHQ1; Database=Employee; Integrated Security=true";
            Console.WriteLine("Enter product id:");
            int productID=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name:");
            string productname=Console.ReadLine();
            Console.WriteLine("Enter product price:");
            int price=int.Parse(Console.ReadLine());    
            Console.WriteLine("Enter product quantity:");
            int quantity=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product category:");
            string category = Console.ReadLine();
            string cmdText = string.Format("INSERT INTO Product VALUES({0},'{1}',{2},{3},'{4}')", productID, productname, price, quantity, category);
            SqlConnection conn=new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd=new SqlCommand(cmdText, conn);
            int ur = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows affected:" + ur);
            Console.WriteLine("Database updated succesfully");
            conn.Close();
            Console.ReadLine();
        }
    }
}