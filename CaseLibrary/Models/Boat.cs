using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Entities
{
    public class Boat
    {
        public string BoatNumber { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Measurements { get; set; }
        public int YearOfConstruction { get; set; }
        public string NeedsRepair { get; set; }
        public string LastRepair { get; set; }
        public string LastMaintenance { get; set; }

        public Boat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance)
        {
            BoatNumber = boatNumber;
            Name = name;
            Model = model;
            Measurements = measure;
            YearOfConstruction = yearOfConstruction;
            NeedsRepair = needsRepair;
            LastRepair = lastRepair;
            LastMaintenance = lastMaintenance;

        }








    }
}
