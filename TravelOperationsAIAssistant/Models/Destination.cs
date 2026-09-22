using System;
using System.Collections.Generic;
using System.Text;

namespace TravelOperationsAIAssistant.Models
{
    internal class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripption { get; set; }

        public List<string> Attractions { get; set; }
        public List<string> Activities { get; set; }


        public Destination(int id,string name,string descriptions)
        {
            Id = id;
            Name = name;
            Descripption = descriptions;
            
            
        }
        
            
        }
    }

