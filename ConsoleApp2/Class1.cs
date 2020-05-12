using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
    

namespace ConsoleApp2
{
    class Search
    {
        public delegate void Del();

        public event Del onCount;

        public void Count()
        {
            Console.WriteLine("Hello World!");
            Random rnd = new Random();
            string[] robot = { "Вперед", "Назад", "Влево", "Вправо" };

            int mIndex = 0;

            while (mIndex != 1)
            {
                mIndex = rnd.Next(robot.Length);
                if (mIndex == 1)
                {
                    onCount();
                }
                else
                {
                    Console.WriteLine(robot[mIndex]);
                }
            }
        }
    }
}
