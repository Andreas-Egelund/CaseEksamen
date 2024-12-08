using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models
{
    public class RowBoat : Boat
    {
        public string WoodGrain { get; set; }


        public RowBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance, string woodGrain) : base(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance)
        {
            WoodGrain = woodGrain;

        }


        public override string ToString()
        {

            return $"" +
                $"BoatNumber: {BoatNumber}\n" +
                $"Name {Name}\n" +
                $"Model: {Model}\n" +
                $"Measurements: {Measurements}\n" +
                $"Year of Construction {YearOfConstruction}\n" +
                $"Needs Repair: {NeedsRepair}\n" +
                $"Last Repair: {LastRepair}\n" +
                $"Last Maintenance: {LastMaintenance}\n" +
                $"Wood type: {WoodGrain}\n";


        }





    }
}
