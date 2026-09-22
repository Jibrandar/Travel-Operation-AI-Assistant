using System;
using System.Collections.Generic;
using System.Text;
using TravelOperationsAIAssistant.Models;

namespace TravelOperationsAIAssistant.Data
{
    internal static class DestinationsData
    {
        public static List<Destination> Destinations = new()
        {
            new(1, "Pahalgam", "Pahalgam is a beautiful hill station in Anantnag district known for its valleys, rivers and scenic landscapes")
            {
                Attractions = new()
                {
                    "Betaab Valley",
                    "Aru Valley",
                    "Lidder River",
                    "Baisaran Valley"
                },
                Activities = new()
                {
                    "Horse Riding",
                    "River Side Walk",
                    "Trekking",
                    "Nature Photography"
                }
            },

            new(2, "Gulmarg", "Gulmarg is a famous mountain destination known for its snow-covered landscapes and skiing activities")
            {
                Attractions = new()
                {
                    "Gulmarg Gondola",
                    "Gulmarg Golf Course",
                    "Apharwat Peak",
                    "St Mary's Church"
                },
                Activities = new()
                {
                    "Skiing",
                    "Snowboarding",
                    "Gondola Ride",
                    "Horse Riding"
                }
            },

            new(3, "Sonamarg", "Sonamarg is a scenic mountain destination surrounded by glaciers, mountains and beautiful valleys")
            {
                Attractions = new()
                {
                    "Thajiwas Glacier",
                    "Zoji La",
                    "Sind River",
                    "Baltal"
                },
                Activities = new()
                {
                    "Trekking",
                    "Pony Riding",
                    "Camping",
                    "River Rafting"
                }
            },

            new(4, "Srinagar", "Srinagar is the summer capital of Jammu and Kashmir and is famous for Dal Lake, gardens and houseboats")
            {
                Attractions = new()
                {
                    "Dal Lake",
                    "Mughal Gardens",
                    "Shankaracharya Temple",
                    "Hazratbal Shrine"
                },
                Activities = new()
                {
                    "Shikara Ride",
                    "Houseboat Stay",
                    "Shopping",
                    "Sightseeing"
                }
            },

            new(5, "Doodhpathri", "Doodhpathri is a peaceful meadow destination surrounded by green mountains and flowing streams")
            {
                Attractions = new()
                {
                    "Doodhpathri Meadows",
                    "Shaliganga River",
                    "Tangnar",
                    "Palmaidan"
                },
                Activities = new()
                {
                    "Horse Riding",
                    "Picnic",
                    "Nature Walk",
                    "Photography"
                }
            },

            new(6, "Yusmarg", "Yusmarg is a quiet hill station surrounded by forests, meadows and mountains")
            {
                Attractions = new()
                {
                    "Doodh Ganga",
                    "Nilnag Lake",
                    "Sang-e-Safed",
                    "Yusmarg Meadows"
                },
                Activities = new()
                {
                    "Trekking",
                    "Horse Riding",
                    "Camping",
                    "Nature Walk"
                }
            },

            new(7, "Aru Valley", "Aru Valley is a peaceful valley near Pahalgam known for its green meadows, mountains and scenic views")
            {
                Attractions = new()
                {
                    "Aru Village",
                    "Aru Meadows",
                    "Lidder River",
                    "Kolahoi Glacier Route"
                },
                Activities = new()
                {
                    "Trekking",
                    "Horse Riding",
                    "Camping",
                    "Photography"
                }
            },

            new(8, "Betaab Valley", "Betaab Valley is a beautiful valley near Pahalgam surrounded by mountains and lush green landscapes")
            {
                Attractions = new()
                {
                    "Betaab Valley",
                    "Lidder River",
                    "Mountain Views",
                    "Pine Forests"
                },
                Activities = new()
                {
                    "Picnic",
                    "Photography",
                    "Nature Walk",
                    "Horse Riding"
                }
            },

            new(9, "Gurez Valley", "Gurez Valley is a remote mountain valley known for its natural beauty, traditional villages and surrounding peaks")
            {
                Attractions = new()
                {
                    "Habba Khatoon Peak",
                    "Kishanganga River",
                    "Dawar Village",
                    "Razdan Pass"
                },
                Activities = new()
                {
                    "Trekking",
                    "Camping",
                    "Fishing",
                    "Photography"
                }
            },

            new(10, "Kokernag", "Kokernag is a scenic destination known for its natural springs, gardens and surrounding mountains")
            {
                Attractions = new()
                {
                    "Kokernag Spring",
                    "Botanical Garden",
                    "Trout Fish Farm",
                    "Kokernag Gardens"
                },
                Activities = new()
                {
                    "Nature Walk",
                    "Fishing",
                    "Picnic",
                    "Photography"
                }
            }
        };
    }
}
