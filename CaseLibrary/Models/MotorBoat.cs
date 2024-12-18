using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models
{
    public class MotorBoat : Boat
    {
        public IEngine Engine { get; set; }

        public MotorBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance, IEngine engine) : 
            base(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance)
        {
            Engine = engine;
        }
        public override string PrintAllBoatInfo()
        {
            return base.PrintAllBoatInfo() + $"This is a MotorBoat with this engine:\n {Engine}";
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
                $"Engine info: {Engine}\n";
        }
    }
}
