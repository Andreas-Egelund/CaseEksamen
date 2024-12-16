using CaseLibrary.Entities;
using CaseLibrary.Models;
using CaseLibrary.Models.EngineTypes;
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
            {"bob.smith@example.com", new User("Bob Smith", "bob.smith@example.com", "SecurePass456!", "555-987-6543", "456 Oak Ave.", "Riverdale", "UL67890")},
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
            { "BE-Id-101", new BookableEvent("Conference", "30/6/2024", "2 hours") },
            { "BE-Id-102", new BookableEvent("Workshop", "20/2/2025", "3 hours") },
            { "BE-Id-103", new BookableEvent("Webinar", "9/5/2024", "1 hour") },
            { "BE-Id-104", new BookableEvent("Networking", "14/1/2025", "4 hours") },
            { "BE-Id-105", new BookableEvent("Seminar", "16/11/2024", "2 hours") },
        };




        private static readonly Dictionary<string, Booking> Bookings = new Dictionary<string, Booking>()
        {

            {"BK-Id-101", new Booking(Boats["RB004"], "25/03/2024", "2 hours", "Location") },
            {"BK-Id-102", new Booking(Boats["MB004"], "20/02/2024", "4 hours", "Riverdale Harbor")},
            {"BK-Id-103", new Booking(Boats["SB005"], "10/03/2024", "1 day", "Lakeview Dock")},
            {"BK-Id-104", new Booking(Boats["SB001"], "25/03/2024", "3 hours", "Seaside Bay")},
            {"BK-Id-105", new Booking(Boats["MB003"], "01/04/2024", "6 hours", "Greenville Port")}

        };






        public static Dictionary<string, BookableEvent> GetAllEvents() { return Events; }

        public static Dictionary<string, Boat> GetBoats() { return Boats; }

        public static Dictionary<string, Booking> GetBookings() { return Bookings; }

        public static Dictionary<string, User> GetUsers() { return Users; }

        public static Dictionary<string, Blog> GetBlogs() { return Blogs; }




        private static readonly Dictionary<string, Blog> Blogs = new Dictionary<string, Blog>()
        {
        { "BL001", new Blog("Season Highlights",

            Users["alice.johnson@example.com"],

            "What an incredible season it’s been for Breezeway Sailing Club:\n" +
            "From first-time racers to seasoned veterans, our members have accomplished so much this year.\n"+
            "Here’s a look back at some of the standout moments, from championship wins to personal milestones.\n"+
            "First, we want to congratulate our members who secured podium finishes at the prestigious What an incredible season it’s been for Breezeway Sailing Club.\n"+
            "Their hard work and dedication truly paid off, and they’ve set the bar high for the future.\n" +
            "It’s not just about the victories; it’s about the passion and effort that every single member brings to the club.\n" +
            "From the seasoned sailors to those just starting, everyone has shown incredible improvement and growth.\n" +
            "Not only did we see impressive performances at competitions, but several of our members also achieved personal bests.\n" +
            "Whether it was breaking speed records or perfecting technique, it’s been amazing to witness these achievements.\n" +
            "In addition to individual successes, we’ve also seen our club grow in numbers this year.\n"+
            "New faces have joined, bringing fresh energy and excitement, and it’s been a pleasure to watch everyone come together.\n" +
            "The camaraderie and team spirit within our club are stronger than ever, and it’s clear that we’re more than just a group of sailors—we’re a family.\n" +
            "Looking ahead to the next season, we are filled with anticipation and determination.\n"+
            "The accomplishments of this season have inspired us all to push even harder next year.\n" +
            "Thank you to all our members for their dedication, and to everyone who has supported us along the way.\n" +
            "Together, we will continue to set new records and reach new milestones.\n" +
            "Let’s keep sailing towards success, together",

            "2024-12-01") },
        { "BL002", new Blog("Sailing Community",

            Users["bob.smith@example.com"],

            "The Impact of Sailing on Community at Our Sailing Club:\n" +
            "This year, we’ve witnessed how sailing is not just about wind and waves, but also about the strong community \n" +
            "we’ve built at our sailing club. From the first sailing lessons to the more challenging races, we’ve seen how\n" +
            "the sport connects us across all experience levels and ages.\n" +
            "It’s been amazing to see how members, from beginners to seasoned sailors, have helped each other and learned\n" +
            "from one another. Friendships have been formed on the boats, and the camaraderie among members has never been stronger.\n" +
            "One of the highlights of this year has been the social events and gatherings we've organized both on and off the water.\n" +
            "Whether it was group sailing trips, barbecues, or races, we’ve had the opportunity to share our passion for sailing and \n" +
            "also build lasting relationships.\n" +
            "Sailing is a sport where teamwork is essential, and we’ve seen that in practice at our club. Everyone has contributed \n" +
            "their unique skills and knowledge, creating an environment where everyone feels welcome. It’s not just the individual\n " +
            "achievements that matter, but how we work together as a team.\n"+
            "This year, our club has grown, and we've seen new faces join us. New members have brought fresh energy and perspectives,\n" +
            "which has made our community even stronger. There’s always room for more sailors, and we’re happy to welcome new members\n" +
            "into our club.\n" +
            "Looking ahead to the next season, we are filled with energy and optimism. Our strong sense of community will continue \n" +
            "to be the foundation of the club’s future, and we look forward to even more fun and inspiring experiences together.\n" +
            "A huge thank you to all our members for their contributions, and to everyone who has been a part of our journey this year.\n" +
            "Let’s continue sailing towards new adventures and strengthening our community.\n" +
            "Together, we will sail toward success – both on and off the water!",

            "2024-11-25") },
        { "BL003", new Blog("Sailing Growth",

            Users["charlie.brown@example.com"],

            "Improving Sailing Skills: A Year of Growth at Our Sailing Club:\n" +
            "As we reflect on the year, it’s clear that one of our greatest achievements has been the progress we’ve made in improving\n" +
            "our sailing skills. Whether it was our seasoned sailors perfecting their techniques or new members mastering the basics, \n" +
            "it’s been a year of learning and growth.\n" +
            "\n" +
            "We are incredibly proud of how everyone has stepped up their game, pushing through challenges and becoming better sailors. \n" +
            "The coaching and mentorship from experienced club members has been invaluable, helping our newer sailors reach new heights.\n" +
            "\n" +
            "It hasn’t been just about technique though; it’s been about gaining confidence on the water, learning how to handle \n" +
            "unexpected conditions, and developing the teamwork required to succeed in races. We’ve seen significant improvements \n" +
            "in our members’ overall sailing abilities, and we couldn’t be more excited for the future.\n" +
            "\n" +
            "Looking forward, we’re committed to continuing this journey of skill development. The next season will bring more training, \n" +
            "workshops, and opportunities to learn from one another. Together, we’ll keep pushing our limits and striving for excellence \n" +
            "on the water.\n" +
            "\n" +
            "A huge thank you to everyone who has worked hard to improve their sailing skills. With your dedication, we know we’ll \n" +
            "continue to reach new milestones together!",

            "2024-12-03") },

        { "BL004", new Blog("Friendly Competition",

            Users["diana.prince@example.com"],

            "Celebrating the Spirit of Friendly Competition at Our Sailing Club:\n" +
            "This year, we’ve had the privilege of watching our club engage in exciting competitions, with the spirit of friendly rivalry \n" +
            "leading the way. Whether it was our local regattas or fun weekend races, the competitive energy at our club has been \n" +
            "nothing short of inspiring.\n" +
            "\n" +
            "At the heart of these competitions is the camaraderie that defines our sailing club. While everyone is racing to be first, \n" +
            "there’s always a focus on supporting each other, sharing tips, and celebrating each other's achievements. This year, we’ve \n" +
            "seen so many members stepping up their game, with some truly impressive performances on the water.\n" +
            "\n" +
            "But it’s not just about winning trophies—it’s about the lessons learned, the friendships made, and the fun shared during every \n" +
            "race. The energy of competition has brought us closer as a club and has helped everyone improve in ways they never expected.\n" +
            "\n" +
            "Looking ahead, we’re excited for more friendly races and challenges in the next season. Whether you’re a seasoned competitor \n" +
            "or a newcomer, there’s always room for growth, fun, and a chance to show off the skills you’ve been working on.\n" +
            "\n" +
            "Thank you to everyone who has embraced the spirit of friendly competition this year. We look forward to many more races, \n" +
            "friendships, and unforgettable moments in the seasons to come!",

            "2024-12-05") },



        };
    } 
}


