using CaseLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Models
{
    public class JetDriveEngine : IEngine
    {

        public JetDriveEngine(string type, int enginePower, string engineRating, string engineSpeed)
        {
            Type = type;
            EnginePower = enginePower;
            EngineRating = engineRating;
            EngineSpeed = engineSpeed;
        }

        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int EnginePower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineRating { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EngineSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string AllEngineInfo()
        {
            throw new NotImplementedException();
        }
    }
}
