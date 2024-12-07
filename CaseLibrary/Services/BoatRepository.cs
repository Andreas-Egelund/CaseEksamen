using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Servicses
{
    public class BoatRepository : IBoatRepository
    {
        private Dictionary<string, Boat> _boats;



        public BoatRepository()
        {
            _boats = MockData.GetBoats();
        }


        public void AddBoat(string sailNumber, Boat boat)
        {
            _boats.TryAdd(sailNumber, boat);
        }

        public void DeleteBoatBySailNumber(string sailNumber)
        {
            if (_boats.Keys.Contains(sailNumber))
            {
                _boats.Remove(sailNumber);
            }
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
