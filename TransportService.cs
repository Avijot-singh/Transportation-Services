using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace net
{



    public class TransportService
    {
        // Properties
        public string PickupSpot { get; set; }
        public string Destination { get; set; }
        public string TotalCost { get; private set; }


        private string userInput;


        public void DisplayMenu()
        {
            Console.WriteLine("Menu Display");
            Console.WriteLine("1.   Uber");
            Console.WriteLine("2.   Taxi");
            Console.WriteLine("3.   Train");
            Console.WriteLine("4.   Bus");
            Console.WriteLine("---------------------------------------------");

             userInput = Console.ReadLine();

            if(int.TryParse(userInput, out int user))
            {
                switch(user)
                {
                    case 1:
                        BookService();
                        break;
                }
            }
           

        }

        public virtual void BookService() // You create this method with virtual keyword so you can use it for ovveride and leave the body empty
        {
            Console.WriteLine("This is the base implementation for booking service");
            
        }
        

        public void ProcessServiceSelection()
        {
            
        }

        
     



    }
    public class Uber : TransportService
    {
        public override void BookService()
        {
            Console.WriteLine("Please enter your uber pickup spot:");
             PickupSpot = Console.ReadLine();
            Console.WriteLine("Please enter your uber destination:");
             Destination = Console.ReadLine();
            Console.WriteLine($"Your uber from {PickupSpot}to {Destination} has been confirmed");
            Console.WriteLine("Total being $200");

            

        }


    }
}