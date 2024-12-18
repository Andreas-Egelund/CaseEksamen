using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.interfaces
{
    public interface IEngine
    {
        string Type { get; set; }

        int EnginePower { get; set; }

        string EngineRating { get; set; }

        string EngineSpeed { get; set; }



    }
}
