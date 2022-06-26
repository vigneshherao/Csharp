using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    internal class Tasks
    {
        public static void New()
        {
            String car = "i20";
            String company = "Hyundai";
            //Double Mileage = 12.5;
            Console.WriteLine("Enter your driving kilometers:-");
            int kilo = Convert.ToInt32(Console.ReadLine());
            double result = kilo * 12.5;
            Console.WriteLine("Car name " + car + "Company name" + company);
            Console.WriteLine("you will get mileage of: "+result);



        }
        
    }
}
