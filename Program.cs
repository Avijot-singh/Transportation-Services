using System;

namespace net
{
    class Program
    {
        static void Main(string[] args)
        {

            // Now, create an instance of Uber
            Uber uberService = new Uber();

            // Run the Uber-specific logic
            uberService.DisplayMenu(); // This will display the Uber-specific menu
            
            
        }
    }
}