using System;

namespace ConsoleProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            string password = "123";

            if(username == "admin" && password == "123")
            {
                Console.WriteLine("Welcome admin");
            } else
            {
                Console.WriteLine("Acces denied");
            }
            Console.Read();
        }
    }
}