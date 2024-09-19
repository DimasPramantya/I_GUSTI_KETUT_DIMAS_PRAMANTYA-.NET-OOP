using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] bootcamp = { "Dimas", "Sugeng", "Joko", "Wilson" };
            //var query = from n in bootcamp select n;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7,8 ,9 ,10};
            //var query = from n in numbers 
            //            where n > 5 
            //            orderby n descending 
            //            select n;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            int input;
            bool check = false;
            while (!check)
            {
                Console.Write("Enter number: ");
                input = Convert.ToInt32(Console.ReadLine());
                if(input < 1 || input > 10)
                {
                    System.Console.WriteLine("Tebak antara 1-10");
                }
                else
                {
                    if(input == number)
                    {
                        Console.WriteLine("benar!");
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Salah");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            } 
        }
    }
}
