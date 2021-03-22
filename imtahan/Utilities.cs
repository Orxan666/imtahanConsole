using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imtahan
{
    static class Utilities
    {
        public static bool IsNumber(string text)
        {
            try
            {
                Convert.ToInt32(text);
                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("zehmet olmasa reqem daxil edin");
                return false;         
            }
        }
    }
}
