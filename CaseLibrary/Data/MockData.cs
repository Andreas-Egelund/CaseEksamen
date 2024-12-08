using CaseLibrary.Entities;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Data
{
    public static class MockData
    {

        private static readonly Dictionary<string, User> Users = new Dictionary<string, User>()
        {

            {"alice.johnson@example.com", new User("Alice Johnson", "alice.johnson@example.com", "Password123!", "555-123-4567", "123 Maple St.", "Springfield", "12345") },
            {"bob.smith@example.com", new User("Bob Smith", "bob.smith@example.com", "SecurePass456!", "555-987-6543", "456 Oak Ave.", "Riverdale", "67890")},
            {"charlie.brown@example.com", new User("Charlie Brown", "charlie.brown@example.com", "Charlie789!", "555-456-7890", "789 Birch Ln.", "Greenville", "13579")},
            {"diana.prince@example.com", new User("Diana Prince", "diana.prince@example.com", "Wonder123!", "555-321-6549", "321 Pine Dr.", "Metropolis", "24680")},
            {"ethan.hunt@example.com", new User("Ethan Hunt", "ethan.hunt@example.com", "MissionImpossible1!", "555-654-1239", "654 Elm Ct.", "Hill Valley", "11223")}

        };



        private static readonly Dictionary<string, Boat> Boats = new Dictionary<string, Boat>()
        {
            {"RB001", new RowBoat("RB001", "Sea Breeze", "Classic Model A", "15ft", 1985, "No", "2022-10-12", "2023-05-20", "Oak") },
            {"RB002", new RowBoat("RB002", "Wave Rider", "Compact Model X", "12ft", 1995, "Yes", "2020-06-15", "2023-03-15", "Pine")},
            {"RB003", new RowBoat("RB003", "Lake Cruiser", "Family Model B", "18ft", 2005, "No", "2021-07-10", "2023-07-12", "Mahogany")},
            {"RB004", new RowBoat("RB004", "River Scout", "Sport Model S", "14ft", 2010, "No", "2023-01-18", "2023-08-10", "Cherry")},
            {"RB005", new RowBoat("RB005", "Ocean Drifter", "Explorer Model Z", "20ft", 1990, "Yes", "2018-09-05", "2023-06-25", "Teak")},


            {"MB001", new MotorBoat("MB001", "Speedster", "Sport Model X", "20ft", 2015, "No", "2022-11-20", "2023-04-15", new JetDriveEngine("DI09 070M", 250,"ICFN", "2000"))},
            {"MB002", new MotorBoat("MB002", "Wave Runner", "Luxury Model A", "25ft", 2012, "Yes", "2021-07-12", "2023-03-30", new JetDriveEngine("DI09 072M", 350, "ICFN", "1900"))},
            {"MB003", new MotorBoat("MB003", "Ocean Spirit", "Explorer Model B", "30ft", 2018, "No", "2023-01-10", "2023-08-05", new JetDriveEngine("DI16 093M", 433, "IFN", "1400"))},
            {"MB004", new MotorBoat("MB004", "Lake Racer", "Classic Model C", "18ft", 2009, "Yes", "2020-09-15", "2023-06-10", new JetDriveEngine("DI16 076M", 846, "ICFN", "2300"))},
            {"MB005", new MotorBoat("MB005", "River Voyager", "Adventure Model Z", "28ft", 2020, "No", "2022-10-18", "2023-09-20", new JetDriveEngine("DI16 304M", 542, "IFN", "1700"))},


            {"SB001", new SailBoat("SB001", "Wind Whisper", "Classic Sail A", "25ft", 2010, "No", "2023-01-15", "2023-06-20", "Dacron") },
            {"SB002", new SailBoat("SB002", "Ocean Voyager", "Cruiser Model B", "30ft", 2015, "Yes", "2021-09-10", "2023-07-12", "Laminated Mylar")},
            {"SB003", new SailBoat("SB003", "Harbor Breeze", "Leisure Sail C", "20ft", 2005, "No", "2022-10-25", "2023-05-18", "Polyester")},
            {"SB004", new SailBoat("SB004", "Sea Runner", "Racing Model D", "28ft", 2018, "No", "2023-03-22", "2023-09-05", "Kevlar")},
            {"SB005", new SailBoat("SB005", "Lagoon Dreamer", "Luxury Sail E", "35ft", 2020, "No", "2023-02-15", "2023-08-30", "Carbon Fiber")}
        };




        private static readonly Dictionary<string, Booking> Bookings = new Dictionary<string, Booking>()
        {

            {"BK001", new Booking("BK001", Users["alice.johnson@example.com"], Boats["RB004"], "TestDato", "TestDuration", "Location") },
            {"BK002", new Booking("BK002", Users["bob.smith@example.com"], Boats["MB004"], "2024-02-20", "4 hours", "Riverdale Harbor")},
            {"BK003", new Booking("BK003", Users["charlie.brown@example.com"], Boats["SB005"], "2024-03-10", "1 day", "Lakeview Dock")},
            {"BK004", new Booking("BK004", Users["diana.prince@example.com"], Boats["SB001"], "2024-03-25", "3 hours", "Seaside Bay")},
            {"BK005", new Booking("BK005", Users["ethan.hunt@example.com"], Boats["MB003"], "2024-04-01", "6 hours", "Greenville Port")}

        };







        public static Dictionary<string, Boat> GetBoats() { return Boats; }

        public static Dictionary<string, Booking> GetBookings() { return Bookings; }
        
        public static Dictionary<string, User> GetUsers() { return Users; }
    }
}
