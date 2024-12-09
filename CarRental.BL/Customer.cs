using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Common;

namespace CarRental.BL
{
    public class Customer :ILogger
    {
        public int CustomerId
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        }
        public string DriverLicenseNumber
        {
            get; set;
        }

        public string Error()
        {
            throw new NotImplementedException();
        }

        public string Info()
        {
            throw new NotImplementedException();
        }

        public string Warn()
        {
            throw new NotImplementedException();
        }
    }
}
