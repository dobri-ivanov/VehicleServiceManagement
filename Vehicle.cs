﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleServiceManagement
{
    public class Vehicle
    {
        public Vehicle(int id, string make, string model, string licensePlate, string horsePower, string capacity, string year, string fuel, string transmission, int clientID)
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
    }
}
