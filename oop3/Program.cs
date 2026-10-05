namespace oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Overloading, Overriding, and Binding
            //a) What is the difference between Method Overloading and Method Overriding?
            //-Method overloading: Defining multiple methods with the same name in the same class,
            //but with different parameter lists(different number, types, or order of parameters).
            //- Method overriding: A subclass provides a new implementation of an inherited method with the same name
            //and parameter list.The method that runs is selected at runtime based on the object’s actual type.

            //b) What is the difference between Static Binding and Dynamic Binding?
            //-Static binding: The method to execute is determined at compile time.
            //-Dynamic binding: The method to execute is determined at runtime based on the object’s actual type.
            //It is commonly associated with overriding and polymorphism.
            #endregion

            #region Console Application 

            DeliveryCenter deliveryCenter = new DeliveryCenter();
            Console.Write("enter delivery center name : ");
            deliveryCenter.CenterName = Console.ReadLine();


            StandardShipment standardShipment = new StandardShipment();
            ExpressShipment expressShipment = new ExpressShipment();
            InternationalShipment internationalShipment = new InternationalShipment();

            Console.Write("enter trackingcode : ");
            standardShipment.trackingcode = Console.ReadLine();
            Console.Write("enter description : ");
            standardShipment.description = Console.ReadLine();
            Console.Write("enter weight : ");
            standardShipment.weight = decimal.Parse(Console.ReadLine());
            Console.Write("enter delivery fee : ");
            standardShipment.deliveryfee = decimal.Parse(Console.ReadLine());

            Console.Write("enter extra fee : ");
            expressShipment.extraFee = decimal.Parse(Console.ReadLine());
            Console.Write("enter trackingcode : ");
            expressShipment.trackingcode = Console.ReadLine();
            Console.Write("enter description : ");
            expressShipment.description = Console.ReadLine();
            Console.Write("enter weight : ");
            expressShipment.weight = decimal.Parse(Console.ReadLine());
            Console.Write("enter delivery fee : ");
            expressShipment.deliveryfee = decimal.Parse(Console.ReadLine());

            Console.Write("enter customs fee : ");
            internationalShipment.customsfee = decimal.Parse(Console.ReadLine());
            Console.Write("destination country : ");
            internationalShipment.destinationcountry = Console.ReadLine();
            Console.Write("enter trackingcode : ");
            internationalShipment.trackingcode = Console.ReadLine();
            Console.Write("enter description : ");
            internationalShipment.description = Console.ReadLine();
            Console.Write("enter weight : ");
            internationalShipment.weight = decimal.Parse(Console.ReadLine());
            Console.Write("enter delivery fee : ");
            internationalShipment.deliveryfee = decimal.Parse(Console.ReadLine());

            deliveryCenter.AddShipment(standardShipment);
            deliveryCenter.AddShipment(expressShipment);
            deliveryCenter.AddShipment(internationalShipment);

            deliveryCenter.PrintAllShipments();

            DeliveryHelper deliveryHelper = new DeliveryHelper();
            deliveryHelper.PrintShipmentDetails(standardShipment);

            expressShipment.updateWeight(4);
            internationalShipment.updateWeight(1, 5);

            Console.Write("enter code because search : ");
            string code = Console.ReadLine();
            if (deliveryCenter[code] != null)
            {
                Console.WriteLine($"the shipment is available {code}-{deliveryCenter[code].description}");
            }
            else
            {
                Console.WriteLine($"the shipment is not available");
            }


            Console.Write("Enter Tracking Code to remove : ");
            code = Console.ReadLine();
            if (deliveryCenter.RemoveShipment(code))
            {
                Console.WriteLine("Shipment Removed Successfully");
            }
            else
            {
                Console.WriteLine($"the shipment is not available");
            }
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine();
            deliveryCenter.PrintAllShipments();
            #endregion
        }
    }
}
