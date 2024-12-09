using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BL
{
    public static class ExtensionsMethods
    {
        public static bool IsInDateRange (this Car car)
        {
            var  Year = car.Year;

            return (Year < 1900 || Year > DateTime.Now.Year + 1);
        }
    }
}
