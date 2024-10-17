using GuitarApp.Models;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

        
            Console.WriteLine("Searching for a 12-string guitar:");
            GuitarSpec customerPreference1 = new GuitarSpec("Taylor", "856ce", "acoustic", "Indian Rosewood", "Sitka Spruce", 12);
            List<Guitar> matchingGuitars1 = inventory.Search(customerPreference1);
            DisplaySearchResults(matchingGuitars1);

         
            Console.WriteLine("\nSearching for a 6-string electric guitar with Alder body and Maple top:");
            GuitarSpec customerPreference2 = new GuitarSpec("Fender", "Stratocaster", "electric", "Alder", "Maple", 6);
            List<Guitar> matchingGuitars2 = inventory.Search(customerPreference2);
            DisplaySearchResults(matchingGuitars2);

         
            Console.WriteLine("\nSearching for a 6-string acoustic guitar with Mahogany back and Sitka Spruce top:");
            GuitarSpec customerPreference3 = new GuitarSpec("Martin", "D-28", "acoustic", "Mahogany", "Sitka Spruce", 6);
            List<Guitar> matchingGuitars3 = inventory.Search(customerPreference3);
            DisplaySearchResults(matchingGuitars3);
        }

        private static void InitializeInventory(Inventory inventory)
        {
     
            inventory.AddGuitar("11277", 3999.95, "Fender", "Stratocaster", "electric", "Alder", "Maple", 6);
            inventory.AddGuitar("V95693", 1499.95, "Gibson", "Les Paul", "electric", "Mahogany", "Maple", 6);
            inventory.AddGuitar("70108276", 2295.95, "PRS", "Custom 24", "electric", "Mahogany", "Maple", 6);
            inventory.AddGuitar("12345", 2999.95, "Taylor", "856ce", "acoustic", "Indian Rosewood", "Sitka Spruce", 12);
            inventory.AddGuitar("54321", 2499.95, "Martin", "D-28", "acoustic", "Mahogany", "Sitka Spruce", 6);
        }

        private static void DisplaySearchResults(List<Guitar> matchingGuitars)
        {
            if (matchingGuitars.Count > 0)
            {
                foreach (Guitar guitar in matchingGuitars)
                {
                    GuitarSpec spec = guitar.GetSpec();
                    Console.WriteLine($"Found guitar: {spec.Builder} {spec.Model} ({spec.NumStrings} strings) for ${guitar.GetPrice():0.00}");
                }
            }
            else
            {
                Console.WriteLine("Sorry, no guitars matched your search.");
            }
        }
    }
}
