using System;

namespace CarRental.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            var customersList = new GenericProcessor<Customer>();
            customersList.Add(new Customer
            {
                FirstName = "Muhaimen"
            });
            customersList.Add(new Customer
            {
                FirstName = string.Empty,
            });


        }
    }
    public class Car
    {
        public int CarId
        {
            get; set;
        }
        public string Make
        {
            get; set;
        }
        public string Model
        {
            get; set;
        }
        public int Year
        {
            get; set;
        }
        public string LicensePlate
        {
            get; set;
        }
        public decimal RentalPricePerDay
        {
            get; set;
        }
        public bool IsAvailable
        {
            get; set;
        }

        public Customer this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Make))
                throw new ArgumentException("Make cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(Model))
                throw new ArgumentException("Model cannot be null or empty.");

            if (Year < 1900 || Year > DateTime.Now.Year + 1)
                throw new ArgumentException($"Year must be between 1900 and {DateTime.Now.Year + 1}.");

            if (string.IsNullOrWhiteSpace(LicensePlate))
                throw new ArgumentException("License plate cannot be null or empty.");

            if (RentalPricePerDay <= 0)
                throw new ArgumentException("Rental price per day must be greater than zero.");
        }
    }


    public class Rental
    {
        public int RentalId
        {
            get; set;
        }
        public int CarId
        {
            get; set;
        }
        public int CustomerId
        {
            get; set;
        }
        public DateTime RentalStartDate
        {
            get; set;
        }
        public DateTime RentalEndDate
        {
            get; set;
        }
        public decimal TotalCost
        {
            get; set;
        }

        // Navigation Properties
        public Car Car
        {
            get; set;
        }
        public Customer Customer
        {
            get; set;
        }
    }

    public class Payment
    {
        public int PaymentId
        {
            get; set;
        }
        public int RentalId
        {
            get; set;
        }
        public decimal Amount
        {
            get; set;
        }
        public DateTime PaymentDate
        {
            get; set;
        }
        public string PaymentMethod
        {
            get; set;
        } // e.g., Credit Card, Cash

        // Navigation Property
        public Rental Rental
        {
            get; set;
        }
    }

    public class Employee
    {
        public int EmployeeId
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Role
        {
            get; set;
        } // e.g., Manager, Clerk
        public string Email
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        }
    }


    public class Branch
    {
        public int BranchId
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        }
    }

    public class CarMaintenance
    {
        public int MaintenanceId
        {
            get; set;
        }
        public int CarId
        {
            get; set;
        }
        public DateTime MaintenanceDate
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public decimal Cost
        {
            get; set;
        }

        // Navigation Property
        public Car Car
        {
            get; set;
        }
    }



}