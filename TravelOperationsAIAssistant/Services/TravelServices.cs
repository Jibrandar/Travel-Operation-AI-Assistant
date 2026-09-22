using TravelOperationsAIAssistant.Models;
using TravelOperationsAIAssistant.Data;

namespace TravelOperationsAIAssistant.Services
{
    internal class TravelServices
    {
        private readonly List<TourPackages> packages = null;
        private readonly List<Vehicle> vehicles = null;
        private readonly List<Destination> destinations = null;

        public TravelServices()
        {
            packages = TourPackageData.Packages;
            vehicles = VehicleData.Vehicles;
            destinations = DestinationsData.Destinations;
        }


        public List< TourPackages> SearchPackages(int? durationsDays=null,string destinationName = null)
        {

            if(durationsDays is null && destinationName is null)
            {
                return null;
            }
            List<TourPackages> searchedPackages = new List<TourPackages>();
            foreach (var package in packages)
            {
                foreach (var destination in package.Destinations)
                {
                    if(package.DurationDays==durationsDays || destination == destinationName)
                    {
                        searchedPackages.Add(package);
                    }
                }
            }

            return searchedPackages;

        }
        public TourPackages GetPackage(int id)
        {
           
            foreach(var item in packages)
            {
                if (item.Id == id)
                {
                    return item;
                }


            }
            return null;
        }

        public Vehicle GetAvailableVehicle(int seatingCapacity)
        {
            foreach(var vehicle in vehicles)
            {
                if(vehicle.SeatingCapacity==seatingCapacity && vehicle.IsAvailable == true)
                {
                    return vehicle;
                }


            }
            return null;


        }

        public Destination GetDestinationInfo(string destinationName)
        {
            foreach (var destination in destinations)
            {
                if (destination.Name == destinationName)
                {
                    return destination;
                }

            }

            return null;
        }
    }
}
