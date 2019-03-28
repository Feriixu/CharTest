using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharTest
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = (char)0b0;
            while (true)
            {
                Console.WriteLine(ch.ToString());
                Thread.Sleep(100);
                ch++;
            }

        }
    }
}
