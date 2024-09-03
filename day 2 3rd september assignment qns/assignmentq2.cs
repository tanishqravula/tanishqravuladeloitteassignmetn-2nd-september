using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            int price;
            int quantity;
            double totalamount;
            double discountamount;
            double finalamount;
            Console.WriteLine("Product Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Product Name:");
            name = Console.ReadLine();
            Console.WriteLine("Unit Price:");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantity:");
            quantity =int.Parse(Console.ReadLine());
            Console.WriteLine("Product Id:" +id);
            Console.WriteLine("Product Name:" +name);
            Console.WriteLine("Unit Job:" +price);
            Console.WriteLine("Quantity:" +quantity);
            totalamount = price * quantity;
            Console.WriteLine("Total Amount:" +totalamount);
            if (quantity > 10)
            {
                discountamount = totalamount * 0.1;
            }
            else if (quantity > 20)
            {
                discountamount = totalamount * 0.2;
            }
            else if (quantity > 50)
            {
                discountamount = totalamount * 0.3;
            }
            else
            {
                discountamount = totalamount;
            }
            Console.WriteLine("Discount Amount:" + discountamount);
            finalamount = totalamount - discountamount;
            Console.WriteLine("Final Amount:" + finalamount);
            Console.ReadLine();


        }
    }
}
