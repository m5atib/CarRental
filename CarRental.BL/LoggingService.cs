using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Common;

namespace CarRental.BL
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILogger> loggerList)
        {
            foreach (var item in loggerList)
            {
                Console.WriteLine(item.Info());
            }
        }
    }
}
