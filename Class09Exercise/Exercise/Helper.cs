using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Exercise
{
public static  class Helper
    {
        public static void AppendTextInFile(string path, string result, string date)
        {
            StreamWriter sw = new StreamWriter(path, true);
            if (result == "break")
            {
                throw new Exception("Error");
            }

            sw.WriteLine($"Date of calculation: {date} - Calculation: {result}");
            sw.Dispose();
        }
    }
}
