using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models
{
    public class SailBoat : Boat
    {
        public string SailMaterial { get; set; }



        public SailBoat(string boatNumber, string name, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance, string sailMaterial) : base(boatNumber, name, model, measure, yearOfConstruction, needsRepair, lastRepair, lastMaintenance)
        {
            SailMaterial = sailMaterial;
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
                $"SailMaterial: {SailMaterial}\n";


        }


    }
}
