using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood, int numStrings)
        {
            GuitarSpec spec = new GuitarSpec(builder, model, type, backWood, topWood, numStrings);
            Guitar guitar = new Guitar(serialNumber, price, spec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.GetSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null; 
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();
            foreach (Guitar guitar in guitars)
            {
            
                if (guitar.GetSpec().Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }
            return matchingGuitars; 
        }
    }

}
