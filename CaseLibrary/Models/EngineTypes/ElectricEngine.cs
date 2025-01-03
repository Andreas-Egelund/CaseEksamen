﻿using CaseLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models.EngineTypes
{
    public class ElectricEngine : IEngine
    {

        public ElectricEngine(string type, int enginePower, string engineRating, string engineSpeed)
        {
            Type = type;
            EnginePower = enginePower;
            EngineRating = engineRating;
            EngineSpeed = engineSpeed;
        }

        public string Type { get; set; }
        public int EnginePower { get; set; }
        public string EngineRating { get; set; }
        public string EngineSpeed { get; set; }



        public override string ToString()
        {
            return $"\n---ElectricEngine---\n" +
                $"Type: {Type}\n" +
                $"Engine power: {EnginePower}HP\n" +
                $"Engine Rating: {EngineRating}\n" +
                $"Engine speed: {EngineSpeed}RPM\n";
        }




    }
}
