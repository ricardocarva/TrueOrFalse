using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    public class Tools
    {
        public static void SetUpInputStream(string sample)
        {
            if (sample == null)
            {
                Console.SetIn(new System.IO.StreamReader("true.txt"));
            }
        }
    }
}
