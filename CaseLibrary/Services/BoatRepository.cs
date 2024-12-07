using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Servicses
{
    public class BoatRepository : IBoatRepository
    {
        public void AddBoat(string sailNumber, Boat boat)
        {
            throw new NotImplementedException();
        }

        public void DeleteBoatBySailNumber(string sailNumber)
        {
            throw new NotImplementedException();
        }

        public void Fixboat(Boat boat)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Boat> GetAllBoats()
        {
            throw new NotImplementedException();
        }

        public Boat GetBoatBySailNumber(string sailNumber)
        {
            throw new NotImplementedException();
        }

        public void UpdateBoatBySailNumber(string sailNumber)
        {
            throw new NotImplementedException();
        }
    }
}
