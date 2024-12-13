using CaseLibrary.Entities;
using CaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CaseLibrary.Data
{
    public static class MockData
    {

        private static readonly Dictionary<string, User> Users = new Dictionary<string, User>()
        {

            {"alice.johnson@example.com", new User("Alice Johnson", "alice.johnson@example.com", "Password123!", "555-123-4567", "123 Maple St.", "Springfield", "BT12345") },
            {"bob.smith@example.com", new User("Alice Johnson", "bob.smith@example.com", "SecurePass456!", "555-987-6543", "456 Oak Ave.", "Riverdale", "UL67890")},
            {"charlie.brown@example.com", new User("Charlie Brown", "charlie.brown@example.com", "Charlie789!", "555-456-7890", "789 Birch Ln.", "Greenville", "PO13579")},
            {"diana.prince@example.com", new User("Diana Prince", "diana.prince@example.com", "Wonder123!", "555-321-6549", "321 Pine Dr.", "Metropolis", "MJ24680")},
            {"ethan.hunt@example.com", new User("Ethan Hunt", "ethan.hunt@example.com", "MissionImpossible1!", "555-654-1239", "654 Elm Ct.", "Hill Valley", "DC11223")}

        };



        private static readonly Dictionary<string, Boat> Boats = new Dictionary<string, Boat>()
        {
            {"RB001", new RowBoat("RB001", "Sea Breeze", "Classic Model A", "15ft", 1985, "No", "2022-10-12", "2023-05-20", "Oak") },
            {"RB002", new RowBoat("RB002", "Wave Rider", "Compact Model X", "12ft", 1995, "Yes", "2020-06-15", "2023-03-15", "Pine")},
            {"RB003", new RowBoat("RB003", "Lake Cruiser", "Family Model B", "18ft", 2005, "No", "2021-07-10", "2023-07-12", "Mahogany")},
            {"RB004", new RowBoat("RB004", "River Scout", "Sport Model S", "14ft", 2010, "No", "2023-01-18", "2023-08-10", "Cherry")},
            {"RB005", new RowBoat("RB005", "Ocean Drifter", "Explorer Model Z", "20ft", 1990, "Yes", "2018-09-05", "2023-06-25", "Teak")},


            {"MB001", new MotorBoat("MB001", "Speedster", "Sport Model X", "20ft", 2015, "No", "20/11/2022", "2023-04-15", new JetDriveEngine("DI09 070M", 250,"ICFN", "2000"))},
            {"MB002", new MotorBoat("MB002", "Wave Runner", "Luxury Model A", "25ft", 2012, "Yes", "12/07/2021", "2023-03-30", new JetDriveEngine("DI09 072M", 350, "ICFN", "1900"))},
            {"MB003", new MotorBoat("MB003", "Ocean Spirit", "Explorer Model B", "30ft", 2018, "No", "10/01/2023", "2023-08-05", new JetDriveEngine("DI16 093M", 433, "IFN", "1400"))},
            {"MB004", new MotorBoat("MB004", "Lake Racer", "Classic Model C", "18ft", 2009, "Yes", "15/09/2020", "2023-06-10", new JetDriveEngine("DI16 076M", 846, "ICFN", "2300"))},
            {"MB005", new MotorBoat("MB005", "River Voyager", "Adventure Model Z", "28ft", 2020, "No", "18/10/2022", "2023-09-20", new JetDriveEngine("DI16 304M", 542, "IFN", "1700"))},


            {"SB001", new SailBoat("SB001", "Wind Whisper", "Classic Sail A", "25ft", 2010, "No", "2023-01-15", "2023-06-20", "Dacron") },
            {"SB002", new SailBoat("SB002", "Ocean Voyager", "Cruiser Model B", "30ft", 2015, "Yes", "2021-09-10", "2023-07-12", "Laminated Mylar")},
            {"SB003", new SailBoat("SB003", "Harbor Breeze", "Leisure Sail C", "20ft", 2005, "No", "2022-10-25", "2023-05-18", "Polyester")},
            {"SB004", new SailBoat("SB004", "Sea Runner", "Racing Model D", "28ft", 2018, "No", "2023-03-22", "2023-09-05", "Kevlar")},
            {"SB005", new SailBoat("SB005", "Lagoon Dreamer", "Luxury Sail E", "35ft", 2020, "No", "2023-02-15", "2023-08-30", "Carbon Fiber")}
        };








        private static readonly Dictionary<string, BookableEvent> Events = new Dictionary<string, BookableEvent>()
        {
            { "CD1102", new BookableEvent("CD1102","Conference", "30/6/2024", "2 hours") },
            { "AD1249", new BookableEvent("AD1249", "Workshop", "20/2/2025", "3 hours") },
            { "LM1437", new BookableEvent("LM1437", "Webinar", "9/5/2024", "1 hour") },
            { "OP1675", new BookableEvent("OP1675", "Networking", "14/1/2025", "4 hours") },
            { "DL1923", new BookableEvent("DL1923", "Seminar", "16/11/2024", "2 hours") },
        };




        private static readonly Dictionary<string, Booking> Bookings = new Dictionary<string, Booking>()
        {

            {"BK001", new Booking("BK001", Boats["RB004"], "25/03/2024", "2 hours", "Location") },
            {"BK002", new Booking("BK002", Boats["MB004"], "20/02/2024", "4 hours", "Riverdale Harbor")},
            {"BK003", new Booking("BK003", Boats["SB005"], "10/03/2024", "1 day", "Lakeview Dock")},
            {"BK004", new Booking("BK004", Boats["SB001"], "25/03/2024", "3 hours", "Seaside Bay")},
            {"BK005", new Booking("BK005", Boats["MB003"], "01/04/2024", "6 hours", "Greenville Port")}

        };

        private static readonly Dictionary<string, Blog> Blogs = new Dictionary<string, Blog>()
        {
        { "BL001", new Blog("The Rise of AI", Users["alice.johnson@example.com"], "Exploring the impact of AI on society.", "2024-12-01") },
        { "BL002", new Blog("Healthy Eating Tips", Users["bob.smith@example.com"], "Simple ways to improve your diet.", "2024-11-25") },
        { "BL003", new Blog("Traveling on a Budget", Users["charlie.brown@example.com"], "Tips for affordable and enjoyable travel.", "2024-12-03") },
        { "BL004", new Blog("Mastering C# Programming", Users["diana.prince@example.com"], "A comprehensive guide to learning C#.", "2024-12-05") },
        { "BL005", new Blog("The Future of Renewable Energy", Users["ethan.hunt@example.com"], "How renewable energy is shaping the world.", "2024-11-20") }
        };





        public static Dictionary<string, BookableEvent> GetAllEvents() { return Events; }

        public static Dictionary<string, Boat> GetBoats() { return Boats; }

        public static Dictionary<string, Booking> GetBookings() { return Bookings; }
        
        public static Dictionary<string, User> GetUsers() { return Users; }

        public static Dictionary<string, Blog> GetBlogs() { return Blogs; }
    }
}
