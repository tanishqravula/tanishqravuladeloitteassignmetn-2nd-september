using System;
using System.Collections.Generic;
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
            string job;
            int salary;
            Console.WriteLine("Employee Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name:");
            name = Console.ReadLine();
            Console.WriteLine("Employee Job:");
            job = Console.ReadLine();
            Console.WriteLine("Employee Salary:");
            salary =int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Id:" +id);
            Console.WriteLine("Employee Name:" +name);
            Console.WriteLine("Employee Job:" +job);
            Console.WriteLine("Employee Salary:" +salary);
            Console.ReadLine();


        }
    }
}
