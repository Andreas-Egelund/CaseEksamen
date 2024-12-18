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
    public class BoatRepository : IBoatRepository // We inherit from our IBoatRepository
    {
        private Dictionary<string, Boat> _boats; // Here we create our dictionary



        public BoatRepository()
        {
            _boats = MockData.GetBoats();  // We take our new dictionary, then we transfer the data from MockData to the new dictionary
        }



        /// <summary>
        /// This method takes the parameter boat of type Boat and adds it to our dictionary of boats where key is the BoatNumber and the boatobject is the value
        /// </summary>
        /// <param name="boat"></param>
        public void AddBoat(Boat boat) 
        {
            _boats.TryAdd(boat.BoatNumber, boat); 
        }


        /// <summary>
        /// This method takes the paramenter sailNumber of type string, that search in the dictionary and if there's a key then it remove the entire <key, value> pair 
        /// </summary>
        /// <param name="sailNumber"></param>
        public void DeleteBoatBySailNumber(string sailNumber)
        {
            if (_boats.Keys.Contains(sailNumber))
            {
                _boats.Remove(sailNumber); 
            }
        }


        /// <summary>
        /// retuns boats dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Boat> GetAllBoats() 
        {
            return _boats; 
        }


        /// <summary>
        /// This method takes the parameter sailNumber of type string, checks if the given key is present in the dictionary, if true returns the corresponding <key,value> Pair
        /// </summary>
        /// <param name="sailNumber"></param>
        /// <returns></returns>
        public Boat GetBoatBySailNumber(string sailNumber) 
        {
            if (_boats.ContainsKey(sailNumber)) 
            {
                return (_boats[sailNumber]); 
            }
            else return null; 
        }



        //TODO This Method is not working as intended. Will overwrite the Boat with given key to have a value of each element until last element in dictionary, resulting in always overwriting given key,valuePair with last element of dict.
        public void UpdateBoatBySailNumber(string sailNumber)
        {
            foreach(var boat in _boats.Values) 
            {
                _boats[sailNumber] = boat; 
            }
        }
    }
}
