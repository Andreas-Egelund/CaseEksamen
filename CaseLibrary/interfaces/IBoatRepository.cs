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

        Boat GetBoatByNumber(int number);

        void AddBoat(Boat boat);
        void RemoveBoat(Boat boat);

        void Fixboat(Boat boat);


    }
}
