using TravelOperationsAIAssistant.Models;

namespace TravelOperationsAIAssistant.Data
{
    internal static class TourPackageData
    {
        public static List<TourPackages> Packages = new()
        {
              new(101, "Kashmir Honeymoon Package", 5, 45999)   {

                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Pahalgam",
                    "Gulmarg",
                    "Sonamarg"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Cab Fare",
                    "Breakfast",
                    "Dinner",
                    "Shikara Ride"
                }
            },

            new(102, "Kashmir Family Tour", 7, 64999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Pahalgam",
                    "Gulmarg",
                    "Sonamarg"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Cab Fare",
                    "Breakfast",
                    "Lunch",
                    "Dinner",
                    "Sightseeing"
                }
            },

            new(103, "Gulmarg Snow Adventure", 4, 32999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Gulmarg"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Cab Fare",
                    "Breakfast",
                    "Dinner",
                    "Gulmarg Sightseeing"
                }
            },

            new(104, "Pahalgam Nature Escape", 4, 28999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Pahalgam",
                    "Aru Valley",
                    "Betaab Valley"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Cab Fare",
                    "Breakfast",
                    "Dinner",
                    "Local Sightseeing"
                }
            },

            new(105, "Kashmir Budget Tour", 5, 35999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Pahalgam",
                    "Gulmarg"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Budget Hotels",
                    "Cab Fare",
                    "Breakfast",
                    "Sightseeing"
                }
            },

            new(106, "Kashmir Premium Experience", 6, 79999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Gulmarg",
                    "Pahalgam",
                    "Sonamarg"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "4 Star Hotels",
                    "Private Cab",
                    "Breakfast",
                    "Lunch",
                    "Dinner",
                    "Shikara Ride",
                    "Sightseeing"
                }
            },

            new(107, "Srinagar City & Dal Lake Tour", 3, 19999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Dal Lake",
                    "Mughal Gardens"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Cab Fare",
                    "Breakfast",
                    "Shikara Ride",
                    "City Sightseeing"
                }
            },

            new(108, "Kashmir Adventure Package", 8, 74999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Pahalgam",
                    "Gulmarg",
                    "Sonamarg",
                    "Aru Valley"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Private Cab",
                    "Breakfast",
                    "Lunch",
                    "Dinner",
                    "Sightseeing",
                    "Adventure Activities"
                }
            },

            new(109, "Kashmir Couple Getaway", 4, 39999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Gulmarg",
                    "Pahalgam"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Private Cab",
                    "Breakfast",
                    "Dinner",
                    "Shikara Ride",
                    "Candlelight Dinner"
                }
            },

            new(110, "Complete Kashmir Explorer", 10, 99999)
            {
                Destinations = new List<string>()
                {
                    "Srinagar",
                    "Pahalgam",
                    "Gulmarg",
                    "Sonamarg",
                    "Aru Valley",
                    "Doodhpathri"
                },
                IncludedServices = new List<string>()
                {
                    "Airport Pick and Drop",
                    "Hotels",
                    "Private Cab",
                    "Breakfast",
                    "Lunch",
                    "Dinner",
                    "Sightseeing",
                    "Shikara Ride",
                    "Tour Guide"
                }
            }
        };

    }
}
