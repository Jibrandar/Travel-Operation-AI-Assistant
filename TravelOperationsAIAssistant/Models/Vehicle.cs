using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOperationsAIAssistant.Models
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string VehicleType { get; set; }
        public int SeatingCapacity { get; set; }
        public decimal DailyRentalPrice { get; set; }
        public bool IsAvailable { get; set; }

        public Vehicle(int id,string name,string vehicleType,int seatingCapacity,decimal dailyRentalPrice,bool isavailable)
        {

            Id = id;
            Name = name;
            VehicleType = vehicleType;
            SeatingCapacity = seatingCapacity;
            DailyRentalPrice = dailyRentalPrice;
            IsAvailable = isavailable;
        }

    }
}
