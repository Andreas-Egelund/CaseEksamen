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


        public void AddBoat(Boat boat)
        {
            _boats.TryAdd(boat.BoatNumber, boat);
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



        public void UpdateBoatBySailNumber(string sailNumber)
        {


            try
            {
                Boat currentBoat = GetBoatBySailNumber(sailNumber);


                Console.WriteLine($"You are editing this Boat: \n\n {currentBoat}");

                Console.WriteLine("Do you want to edit the name of the Boat?\n" +
                    "(Y)es or (N)o?");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new Boat name here: \n");
                    currentBoat.Name = Console.ReadLine();
                }



                Console.WriteLine("Do you want to edit the model of the Boat?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new Boat model here: \n");
                    currentBoat.Model = Console.ReadLine();
                }




                Console.WriteLine("Do you want to edit the lenght of the Boat?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write your new Boat length here: \n");
                    currentBoat.Measurements = Console.ReadLine();
                }




                Console.WriteLine("Do you want to mark something for repair?\n" +
                    "(Y)es or (N)o?");

                answer = Console.ReadLine();

                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    Console.WriteLine("Please write the part that needs repair here: \n");
                    currentBoat.NeedsRepair = Console.ReadLine();
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }



    }

            








    
}
