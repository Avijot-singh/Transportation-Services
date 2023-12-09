using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace net
{
    public class TransportService
    {

        protected bool keepPlaying = true;






        // Properties
        public string PickupSpot { get; set; }
        public string Destination { get; set; }
        public string TotalCost { get; protected set; }


        private string userInput;

      
        public void DisplayMenu()
        {
           
            

                Console.WriteLine("Menu Display");
                Console.WriteLine("1.   Uber");
                Console.WriteLine("2.   Taxi");
                Console.WriteLine("3.   Train");
                Console.WriteLine("4.   Bus");
                Console.WriteLine("---------------------------------------------");


                Console.Write("Please enter your input:");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int user))
                {
                    switch (user)
                    {
                        case 1:
                            BookService();
                            break;
                    }

                }


            
        }


        public virtual void BookService() // You create this method with virtual keyword so you can use it for ovveride and leave the body empty
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
            TotalCost = "$40";

            Console.WriteLine($"Your uber from {PickupSpot} to {Destination} has been qued");
            Console.WriteLine($"Total cost being {TotalCost}");

            Console.WriteLine("Do you confirm the order");
            string Confirm = Console.ReadLine().ToLower();
            if (Confirm == "yes" || Confirm == "y") 
            {
                Console.WriteLine("---------CONFIRMED----------");
            }
            else
            {
                Console.WriteLine("-------ORDER NOT CONFIRMED---------");
            }





        }


    }
}


