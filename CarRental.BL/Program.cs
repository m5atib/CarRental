namespace CarRental.BL
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; } // e.g., Toyota, Ford
        public string Model { get; set; } // e.g 2024, 2010
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DriverLicenseNumber { get; set; }
    }

    public class Rental
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public decimal TotalCost { get; set; }

        // Navigation Properties
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public int RentalId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } // e.g., Credit Card, Cash

        // Navigation Property
        public Rental Rental { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } // e.g., Manager, Clerk
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }


    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class CarMaintenance
    {
        public int MaintenanceId { get; set; }
        public int CarId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        // Navigation Property
        public Car Car { get; set; }
    }



}