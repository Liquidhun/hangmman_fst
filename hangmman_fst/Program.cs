using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangmman_fst
{
    class Program
    {
        static void Main(string[] args)
        {
            draw_man hMan = new draw_man("", 0);
            Console.ReadKey();
        }
    }
}
