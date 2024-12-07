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





    }
}
