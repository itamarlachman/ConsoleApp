using System;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console App Started.");
            Process.Start(ConfigurationManager.AppSettings["app"]);
            Environment.Exit(0);
        }
    }
}
