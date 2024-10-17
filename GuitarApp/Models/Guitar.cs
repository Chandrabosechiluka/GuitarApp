using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    public class Guitar
    {
        public string SerialNumber { get; private set; }
        public double Price { get; private set; }
        public GuitarSpec Spec { get; private set; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }

        public string GetSerialNumber()
        {
            return SerialNumber;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public GuitarSpec GetSpec()
        {
            return Spec;
        }
    }

}
