using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOperationsAIAssistant.Models
{
    public class TourPackages
    {
        public int Id { get; set; }
        public string TourName { get; set; }
        public int DurationDays { get; set; }
        public decimal Price { get; set; }

        public List<string> Destinations { get; set; }
        public List<string> IncludedServices { get; set; }

        public TourPackages(int id, string destinationName, int durationDays, decimal price)
        {
            Id = id;
            TourName = destinationName;
            DurationDays = durationDays;
            Price = price;
        }
    }
}
