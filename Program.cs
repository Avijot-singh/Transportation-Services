using System.Runtime.CompilerServices;
bool isSuccessful = true;
while (isSuccessful)
{
    
    
    static void Taxi()
    {
        Console.WriteLine("Please enter your Taxi pickup spot:");
        string TaxiP = Console.ReadLine();
        Console.WriteLine("Please enter your uber destination:");
        string TaxiI = Console.ReadLine();
        Console.WriteLine($"Your Taxi from {TaxiP} to {TaxiI} has been confirmed");
        Console.WriteLine("Total being $200");
    }
    static void Train()
    {

        Console.WriteLine("Please enter your Train pickup spot:");
        string TrainP = Console.ReadLine();
        Console.WriteLine("Please enter your Train destination:");
        string TrainI = Console.ReadLine();
        Console.WriteLine($"Your Taxi from {TrainP} to {TrainI} has been confirmed");
        Console.WriteLine("Total being $15");
    }
    static void Bus()
    {
        Console.WriteLine("Please enter your Bus pickup spot:");
        string BusP = Console.ReadLine();
        Console.WriteLine("Please enter your Bus destination:");
        string BusI = Console.ReadLine();
        Console.WriteLine($"Your Taxi from {BusP} to {BusI} has been confirmed");
        Console.WriteLine("Total being $200");
    }
    
    
    Console.WriteLine("Do you confirm ?");
    string response = Console.ReadLine();
    if (response == "yes" || response == "y")
    {
        Console.WriteLine("--------CONFIRMED--------");
        isSuccessful = false;
    }
    else
    {
        Console.WriteLine("Confirmed Unsecuessfull");
    }
}