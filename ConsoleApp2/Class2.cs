using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp2
{
    class Class2
    {
        public void Message()
        {
            using (StreamWriter sw = new StreamWriter(@"C:/Users/Zhere/source/repos/ConsoleApp2/ConsoleApp2/bin/Debug/netcoreapp3.1/Events.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Hello World!");
                Console.Write("Запись \"Hello World!\" появилась в документе Events.txt");
            }
        }
    }
}
