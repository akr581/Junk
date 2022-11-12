using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                int x = 0;
                while (x < 15)
                {
                    sb.Append(x);
                    Console.WriteLine(x);
                    System.Threading.Thread.Sleep(1500);
                    x++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                string filePath = @"C:\Temp\Console\test.txt";
                File.WriteAllText(filePath, sb.ToString());
            }

        }
    }
}
