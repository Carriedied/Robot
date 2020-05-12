using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Search Search = new Search();
            Class2 Class2 = new Class2();
            Search.onCount += Class2.Message;
            Search.Count();
        }
    }
}