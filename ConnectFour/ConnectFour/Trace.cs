using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Trace
    {
        public static bool ON = false;
        public static void println(String str)
        {
            if (ON)
            {
                Console.WriteLine(str);
            }
        }
    }

}
