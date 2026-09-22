using System;
using System.Collections.Generic;
using System.Text;
using TravelOperationsAIAssistant.Models;

namespace TravelOperationsAIAssistant.Data
{
    internal static class VehicleData
    {
        public static List<Vehicle> Vehicles = new()
        {

            new(1, "Toyota Innova", "SUV", 7, 3500m, true),
            new(2, "Toyota Innova Crysta", "SUV", 7, 4500m, true),
            new(3, "Maruti Ertiga", "MUV", 7, 2800m, true),
            new(4, "Mahindra Scorpio", "SUV", 7, 4000m, true),
            new(5, "Mahindra Thar", "SUV", 4, 4500m, false),
            new(6, "Maruti Swift Dzire", "Sedan", 5, 2200m, true),
            new(7, "Toyota Etios", "Sedan", 5, 2500m, true),
            new(8, "Tempo Traveller", "Minibus", 12, 5500m, true),
            new(9, "Force Urbania", "Minibus", 17, 7000m, false),
            new(10, "Toyota Fortuner", "SUV", 7, 6500m, true)
        };
    }
}
