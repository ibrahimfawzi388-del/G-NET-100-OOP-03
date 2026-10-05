using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    public class StandardShipment : Shipment
    {
        public StandardShipment() : base() { }

        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            return base.ToString();
        }
    }
}
