using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceManagement
{
    public class Vehicle
    {
        public Vehicle(int id, string make, string model, string licensePlate, string horsePower, string capacity, string year, string fuel, string transmission, int clientID, string firstName, string lastName)
        {
            Id = id;
            LicensePlate = licensePlate;
            HorsePower = horsePower;
            Capacity = capacity;
            Year = year;
            Fuel = fuel;
            Transmission = transmission;
            ClientID = clientID;
            Make = make;
            Model = model;
            FirstName = firstName;
            LastName = lastName;

        }
        public Vehicle(string make, string model, string year, string capacity, string horsePower, string licensePlate)
        { 
            LicensePlate = licensePlate;
            HorsePower = horsePower;
            Capacity = capacity;
            Year = year;
            Make = make;
            Model = model;
        }

        public Vehicle(string licensePlate, string horsePower, string capacity, string year, string fuel, string transmission, string make, string model, string firstName, string lastName)
        {
            LicensePlate = licensePlate;
            HorsePower = horsePower;
            Capacity = capacity;
            Year = year;
            Fuel = fuel;
            Transmission = transmission;
            Make = make;
            Model = model;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string HorsePower { get; set; }
        public string Capacity { get; set; }
        public string Year { get; set; }
        public string Fuel { get; set; }
        public string Transmission { get; set; }
        public int ClientID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
