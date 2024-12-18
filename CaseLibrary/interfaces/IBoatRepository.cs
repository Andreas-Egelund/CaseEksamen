using CaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.interfaces
{
    public interface IBoatRepository
    {
        void AddBoat(Boat boat);

        Dictionary<string, Boat> GetAllBoats();

        Boat GetBoatBySailNumber(string sailNumber);

        void UpdateBoatBySailNumber(string sailNumber);

        void DeleteBoatBySailNumber(string sailNumber);


    }
}
