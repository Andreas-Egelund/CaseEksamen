using CaseLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Entities
{
    public abstract class Boat
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

        public virtual string PrintAllBoatInfo()
        {

            return $"---------------------------------------\n" +
                $"BoatNumber: {BoatNumber}\n" +
                $"Name {Name}\n" +
                $"Model: {Model}\n" +
                $"Measurements: {Measurements}\n" +
                $"Year of Construction {YearOfConstruction}\n" +
                $"Needs Repair: {NeedsRepair}\n" +
                $"Last Repair: {LastRepair}\n" +
                $"Last Maintenance: {LastMaintenance}\n" +
                $"---------------------------------------\n";

        }

        public bool Fixboat()
        {
            if (NeedsRepair != "No")
            {
                LastRepair = $"{NeedsRepair} Fixed on {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
                NeedsRepair = "No";
                LastMaintenance = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";
                return true;
            }
            else return false;
        }






    }
}
