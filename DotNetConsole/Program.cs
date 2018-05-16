using System;

namespace DotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("==========Hello Docker enthusiasts!==========");
            Console.WriteLine("\n");
            Console.WriteLine("I am a .Net Core Console app running inside a container");
            Console.WriteLine($"My host name is: {System.Net.Dns.GetHostName()}");
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            Console.WriteLine("\n");         
        }
    }
}