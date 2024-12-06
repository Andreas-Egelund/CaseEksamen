using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Entities
{
    public class Boat
    {
        private int _number;
        private static int _nextNumber;

        public int _boatNumber;
        public string _name;
        public string _type;
        public string _model;
        public string _measure;
        public int _yearOfConstruction;
        public string _needsRepair;
        public string _lastRepair;
        public string _lastMaintenance;

        public Boat(int boatNumber, string name, string type, string model, string measure, int yearOfConstruction, string needsRepair, string lastRepair, string lastMaintenance)
        {
            _boatNumber = boatNumber;
            _name = name;
            _type = type;
            _model = model;
            _measure = measure;
            _yearOfConstruction = yearOfConstruction;
            _needsRepair = needsRepair;
            _lastRepair = lastRepair;
            _lastMaintenance = lastMaintenance;
            _nextNumber++;
            _number = _nextNumber;

        }








    }
}
