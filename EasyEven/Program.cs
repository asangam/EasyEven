using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 2; i <= 100; i += 2)
                Console.Write("" + i + "\n");
                Console.ReadLine();
        }
    }
}
