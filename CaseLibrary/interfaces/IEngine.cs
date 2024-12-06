using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.interfaces
{
    public interface IEngine
    {
        int Type { get; set; }

        int EnginePower { get; set; }

        int EngineRating { get; set; }

        int EngineSpeed { get; set; }

    }
}
