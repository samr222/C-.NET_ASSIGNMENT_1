using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sam
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("How much did you receive money ($)? ");
            double totalmoney= Convert.ToDouble(Console.ReadLine());

            double books = totalmoney* 0.75;
            double restMoney = totalmoney - books;
            double MoneyperItem = restMoney / 3;
            double coffee = (MoneyperItem / 2);//dividing by 2 as the coffee costs 2 dollars
            double change1 = (MoneyperItem % 2);//collecting change for the white roses
            double computer = (MoneyperItem / 4);// cost of computer is 4 dollars
            double change2 = (MoneyperItem % 4);
            double subway = (MoneyperItem/ 3);//cost of tickets is 3 dollars
            double change3 = (MoneyperItem % 3);

            Console.WriteLine("Book and Supplies: " + books + " $");

            Console.WriteLine("You can then buy: ");

            Console.WriteLine(Math.Floor(coffee) + " coffees");

            Console.WriteLine(Math.Floor(computer) + " Flash Computer Numbers");

            Console.WriteLine(Math.Floor(subway) + " Subway Tickets");

            Console.WriteLine("and you will have " + Math.Floor(change1 + change2 + change3) + " dollars for the white roses.");

            Console.ReadKey();


                
        }
    }

}


