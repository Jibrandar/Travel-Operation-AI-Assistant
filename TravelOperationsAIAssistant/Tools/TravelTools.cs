using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TravelOperationsAIAssistant.Models;
using TravelOperationsAIAssistant.Services;

namespace TravelOperationsAIAssistant.Tools
{
    internal class TravelTools
    {

        private readonly TravelServices service;
        public TravelTools()
        {
            service = new TravelServices();
        }
        [Description("Searching destinations by destination name or durations days and returning a list if both inputs are null it return null  ")]
        public List<TourPackages> SearchPackages(int durationDays,string destinationName)
        {
            return service.SearchPackages(durationDays, destinationName);
        }

        [Description("Get details of a package by id")]
        public TourPackages GetPackage(int id)
        {
            return service.GetPackage(id);
        }

        [Description("Get available vehicle using passenger count")]
        public Vehicle GetAvailbleVehicle(int seatCapacity)
        {
            return service.GetAvailableVehicle(seatCapacity);
        }

        [Description("Get information about a particular destination using destination name")]
        public Destination GetDestination( string destinationName)
        {
            return service.GetDestinationInfo(destinationName);
        }





    }


}  
