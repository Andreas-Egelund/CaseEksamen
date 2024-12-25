// See https://aka.ms/new-console-template for more information

using CaseLibrary.Data;
using CaseLibrary.Entities;
using CaseLibrary.interfaces;
using CaseLibrary.Models;
using CaseLibrary.Models.EngineTypes;
using CaseLibrary.Services;
using CaseLibrary.Servicses;


#region Repo Creation
BoatRepository boatRepo = new BoatRepository();
UserRepository userRepo = new UserRepository();
BookingRepository bookingRepo = new BookingRepository();
BlogRepository blogRepo = new BlogRepository();
EventRepository eventRepo = new EventRepository();
#endregion


#region CRUD METHOD TESTS
//These methods are tested using boatRepo. Would be similar with all other repos. Remember to uncomment test code in each block :)

#region Test of AddBoat() method
//Dictionary<string,Boat> AllBoats = boatRepo.GetAllBoats(); //Saving all boats in AllBoats dict for easier readability

//MotorBoat testMotorBoat = new MotorBoat("MB006","MotorBoatTestName", "MotorBoatTestModel","400 meters", 2024, "No", "25/12/2024","15/11/2024",new ElectricEngine("TestEngineType", 1700,"TestRating","2500 RPM")); //Making a Boat obj for testing purposes


//foreach (Boat boat in AllBoats.Values)  //Printing out all boats before adding new boat
//{
//    Console.WriteLine($"Boat number:  {boat.BoatNumber}");
//}

//Console.WriteLine("-----------------------------------------------------");  //Seperator
//boatRepo.AddBoat(testMotorBoat); //Adds the testMotorBoat obj to our dict of all boats


//foreach (Boat boat in AllBoats.Values)  //Printing out all boats after adding new boat. See Bottom of output "MB006". Add Method Works as intended
//{
//    Console.WriteLine($"Boat number:  {boat.BoatNumber}");
//}


#endregion

#region Test of GetBoatBySailNumber() method

//Boat boat1 = boatRepo.GetBoatBySailNumber("MB005"); // Uses the GetBoatBySailNumber and stores the returned Boat obj in boat1 variable. 

//Console.WriteLine(boat1); //Prints the boat obj retrieved from methodcall. Expected output is the Boat Obj with the SailNumber "MB005". Notice BaseClass Type "Boat" Works even if the returned Boat obj is of type MotorBoat/RowBoat/SailBoat

#endregion

#region Test of UpdateBoatBySailNumber() method

//boatRepo.UpdateBoatBySailNumber("MB005"); //Calls the Update Boat Method. Try editing some of the values by using the controls given (Y)es or (N)o

//Console.WriteLine("\n-----------------------------\n" + boatRepo.GetBoatBySailNumber("MB005")); // Prints out the same boat obj that was edited to check if the changes made by method have been made

#endregion

#region Test of DeleteBoatBySailNumber() method

//Dictionary<string, Boat> AllBoats = boatRepo.GetAllBoats(); //Saving all boats in AllBoats dict for easier readability

//foreach (Boat boat in AllBoats.Values)  //Printing out all Sailnumbers of current boats before removing a boat
//{
//    Console.WriteLine($"Boat number:  {boat.BoatNumber}");
//}

//Console.WriteLine("-----------------------------------------------------");  //Seperator
//boatRepo.DeleteBoatBySailNumber("RB003");

//foreach (Boat boat in AllBoats.Values)  //Printing out all boats after removing a boat. See if BoatNumber used as argument for method param has been removed. Check for "RB003"
//{
//    Console.WriteLine($"Boat number:  {boat.BoatNumber}");
//}

#endregion

#endregion



#region Kode til EksamensTemaer

#region Tema3 : Filtrering/søgning-Dictionary //SHOULD BE MADE DIFFERENT. THIS IS BASICALLY JUST FILTERING OF LIST. NOT USING THE KEY,VALUE ABILITIES OF DICT

//Dictionary<string, Boat> boatDict = boatRepo.GetAllBoats(); //Making a reference to our Dictionary of boats for easier readability

//Dictionary<string, Boat> GetBoatsConstructedAfter(int yearOfCon) // Returns a dictionary of boats Newer than the given year of construction. Argument 1950 would return a dictionary of all boats made after the year 1950
//{
//    Dictionary<string, Boat> filteredBoats = new Dictionary<string, Boat>();

//    foreach(Boat boat in boatDict.Values) // Goes through each element of our dict
//    {
//        if (boat.YearOfConstruction > yearOfCon) //If the current element has a construction year bigger than (or after) the given argument to param yearOfCon. Add this boat to the filteredBoats Dict
//        {
//            filteredBoats.Add(boat.BoatNumber,boat);
//        }
//    }

//    return filteredBoats; //Returns the filtered boats
//}


//foreach(Boat boat in boatDict.Values) //Prints all Boats With sailnumber and YearOfConstruction
//{
//    Console.WriteLine($"{boat.BoatNumber} : {boat.YearOfConstruction}");
//}


//Console.WriteLine("\n-----------------------------------------\n"); //Seperator


//foreach (Boat boat in GetBoatsConstructedAfter(2000).Values) //Prints all Boats constructed after the year 2000 With sailnumber and YearOfConstruction
//{
//    Console.WriteLine($"{boat.BoatNumber} : {boat.YearOfConstruction}");
//}
#endregion

#region Tema4:Filtrering/søgning-List //Same implementation as Tema3. Just converted Dict to List

//List<Boat> boatList = boatRepo.GetAllBoats().Values.ToList(); //Converts our dictionary of boats to a List of boats by accessing only the values of Dict

//List<Boat> GetBoatsConstructedAfter(int yearOfCon) // Returns a List of boats Newer than the given year of construction. Argument 1950 would return a List of all boats made after the year 1950
//{
//    List<Boat> filteredBoats = new List<Boat>();

//    foreach (Boat boat in boatList) // Goes through each element of our List
//    {
//        if (boat.YearOfConstruction > yearOfCon) //If the current element has a construction year bigger than (or after) the given argument to param yearOfCon. Add this boat to the filteredBoats List
//        {
//            filteredBoats.Add(boat);
//        }
//    }

//    return filteredBoats; //Returns the filtered boats
//}


//foreach (Boat boat in boatList) //Prints all Boats With sailnumber and YearOfConstruction
//{
//    Console.WriteLine($"{boat.BoatNumber} : {boat.YearOfConstruction}");
//}


//Console.WriteLine("\n-----------------------------------------\n"); //Seperator


//foreach (Boat boat in GetBoatsConstructedAfter(2000)) //Prints all Boats constructed after the year 2000 With sailnumber and YearOfConstruction
//{
//    Console.WriteLine($"{boat.BoatNumber} : {boat.YearOfConstruction}");
//}

#endregion

#region Tema7:Repetition–kontrolstrukturer


#region Foreach-Loop
//List<Boat> boatList = boatRepo.GetAllBoats().Values.ToList(); //Converts our dictionary of boats to a List of boats by accessing only the values of Dict

//List<Boat> GetBoatsConstructedAfter(int yearOfCon) // Returns a List of boats Newer than the given year of construction. Argument 1950 would return a List of all boats made after the year 1950
//{
//    List<Boat> filteredBoats = new List<Boat>();

//    foreach (Boat boat in boatList) // Goes through each element of our List
//    {
//        if (boat.YearOfConstruction > yearOfCon) //If the current element has a construction year bigger than (or after) the given argument to param yearOfCon. Add this boat to the filteredBoats List
//        {
//            filteredBoats.Add(boat);
//        }
//    }

//    return filteredBoats; //Returns the filtered boats
//}


//foreach (Boat boat in boatList) //Prints all Boats With sailnumber and YearOfConstruction
//{
//    Console.WriteLine($"{boat.BoatNumber} : {boat.YearOfConstruction}");
//}


//Console.WriteLine("\n-----------------------------------------\n"); //Seperator


//foreach (Boat boat in GetBoatsConstructedAfter(2000)) //Prints all Boats constructed after the year 2000 With sailnumber and YearOfConstruction
//{
//    Console.WriteLine($"{boat.BoatNumber} : {boat.YearOfConstruction}");
//}
#endregion

#region While-Loop

//List<Boat> boatList = boatRepo.GetAllBoats().Values.ToList(); //Converts our dictionary of boats to a List of boats by accessing only the values of Dict

//List<Boat> GetBoatsConstructedAfter(int yearOfCon) // Returns a List of boats Newer than the given year of construction. Argument 1950 would return a List of all boats made after the year 1950
//{
//    List<Boat> filteredBoats = new List<Boat>();

//    int elementIndex = 0; // Local variable to keep track of Index. This is used to access each elemnt of our list. Like a foreach loop
//    while (boatList.Count-1 >= elementIndex) //Remember -1 because of ZeroIndexing. This condition makes sure that the while loop has a number iterations appropriate to the amount of elemnts in our List
//    {

//        if(boatList[elementIndex].YearOfConstruction > yearOfCon)
//        {
//            filteredBoats.Add(boatList[elementIndex]);
//        }
//        elementIndex++; //Remember to increment our local variable so that on next iteration we are accessing the next elemnt in our list
//    }

//    return filteredBoats; //Returns the filtered boats
//}

//int elementNumber = 0;
//while (boatList.Count-1 > elementNumber)
//{
//    Console.WriteLine($"{boatList[elementNumber].BoatNumber} : {boatList[elementNumber].YearOfConstruction}");
//    elementNumber++;
//}


//List<Boat> filteredBoatsList = GetBoatsConstructedAfter(2000); //Makes reference to the value of this method call.
//Console.WriteLine("\n-----------------------------------------\n"); //Seperator

//elementNumber = 0; //Resets the variable to 0. Could also make new variable but this is fine.
//while (filteredBoatsList.Count - 1 > elementNumber)
//{
//    Console.WriteLine($"{filteredBoatsList[elementNumber].BoatNumber} : {filteredBoatsList[elementNumber].YearOfConstruction}"); // Prints the values of the list returned from method call
//    elementNumber++;
//}

#endregion

#region For-Loop

//List<Boat> boatList = boatRepo.GetAllBoats().Values.ToList(); //Converts our dictionary of boats to a List of boats by accessing only the values of Dict


//List<Boat> GetBoatsConstructedAfter(int yearOfCon) // Returns a List of boats Newer than the given year of construction. Argument 1950 would return a List of all boats made after the year 1950
//{
//    List<Boat> filteredBoats = new List<Boat>();


//    for (int i = 0; i <= boatList.Count-1; i++) //Making a variable to keep track of index is made here. Incrementing is also handled here. See difference between this and while loop. We also handle the condition here.
//    {

//        if (boatList[i].YearOfConstruction > yearOfCon)
//        {
//            filteredBoats.Add(boatList[i]); // Adding the boat with the current index to filtered list
//        }

//    }

//    return filteredBoats; //Returns the filtered boats
//}



//for (int i = 0;i <= boatList.Count-1;i++) //Prints all Boats With sailnumber and YearOfConstruction
//{
//    Console.WriteLine($"{boatList[i].BoatNumber} : {boatList[i].YearOfConstruction}");
//}


//List<Boat> filteredBoats = GetBoatsConstructedAfter(2000);
//Console.WriteLine("\n-----------------------------------------\n"); //Seperator


//for (int i = 0;i <= filteredBoats.Count-1;i++)
//{
//    Console.WriteLine($"{filteredBoats[i].BoatNumber} : {filteredBoats[i].YearOfConstruction}");
//}


#endregion


#endregion


#endregion