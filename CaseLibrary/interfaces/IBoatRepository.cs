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
        List<Boat> GetAll();

        public Boat GetBoatByNumber(int number);

        public void AddBoat(Boat boat);
        public void RemoveBoat(Boat boat);

        public void Fixboat(Boat boat);


    }
}
