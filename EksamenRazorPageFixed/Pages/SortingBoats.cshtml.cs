using CaseLibrary.Entities;
using CaseLibrary.Servicses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamenRazorPageFixed.Pages
{
    public class SortingBoatsModel : PageModel
    {
        private bool _isSorted = false;

        public bool IsSorted { get => _isSorted; set => _isSorted = value; }




        public Dictionary<string, Boat> Boats { get; set; }

        public List<Boat> SortedBoats { get; set; }

        public SortingBoatsModel(BoatRepository boatRepo)
        {
            Boats = boatRepo.GetAllBoats();
        }


        public void OnGet()
        {
        }


        public void OnPostSortBoats()
        {
            SortedBoats = Boats.Values.ToList();



                Boat temp;

                for (int write = 0; write < SortedBoats.Count; write++)
                {
                    for (int sort = 0; sort < SortedBoats.Count - 1; sort++)
                    {
                        if (SortedBoats[sort].YearOfConstruction > SortedBoats[sort + 1].YearOfConstruction)
                        {
                            temp = SortedBoats[sort + 1];
                            SortedBoats[sort + 1] = SortedBoats[sort];
                            SortedBoats[sort] = temp;
                        }
                    }
                }

                IsSorted = true;
        }



    }
}
