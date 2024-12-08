using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
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



        public Dictionary<string, Boat> GetAllBoats()
        {
            return _boats;
        }

        public Boat GetBoatBySailNumber(string sailNumber)
        {
            if (_boats.ContainsKey(sailNumber))
            {
                return (_boats[sailNumber]);
            }
            else return null;
        }


        
        //TODO NEEDS IMPLEMENTATION 
        public void UpdateBoatBySailNumber(string sailNumber)
        {
            foreach(var boat in _boats.Values) 
            {
                _boats[sailNumber] = boat; 
            }
        }
    }
}
