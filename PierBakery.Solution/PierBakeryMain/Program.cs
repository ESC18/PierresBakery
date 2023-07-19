using System;
using PriceCalc.Models;

namespace UI 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"
███████████   ███                                         ██            ███████████            █████                                   
░░███░░░░░███ ░░░                                         ███           ░░███░░░░░███          ░░███                                    
 ░███    ░███ ████   ██████  ████████  ████████   ██████ ░░░   █████     ░███    ░███  ██████   ░███ █████  ██████  ████████  █████ ████
 ░██████████ ░░███  ███░░███░░███░░███░░███░░███ ███░░███     ███░░      ░██████████  ░░░░░███  ░███░░███  ███░░███░░███░░███░░███ ░███ 
 ░███░░░░░░   ░███ ░███████  ░███ ░░░  ░███ ░░░ ░███████     ░░█████     ░███░░░░░███  ███████  ░██████░  ░███████  ░███ ░░░  ░███ ░███ 
 ░███         ░███ ░███░░░   ░███      ░███     ░███░░░       ░░░░███    ░███    ░███ ███░░███  ░███░░███ ░███░░░   ░███      ░███ ░███ 
 █████        █████░░██████  █████     █████    ░░██████      ██████     ███████████ ░░████████ ████ █████░░██████  █████     ░░███████ 
░░░░░        ░░░░░  ░░░░░░  ░░░░░     ░░░░░      ░░░░░░      ░░░░░░     ░░░░░░░░░░░   ░░░░░░░░ ░░░░ ░░░░░  ░░░░░░  ░░░░░       ░░░░░███ 
                                                                                                                               ███ ░███ 
                                                                                                                              ░░██████  
                                                                                                                               ░░░░░░   
            ");
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Please enter how many loaves of bread you want: They are $5 each and buy 2 get 1 free!");
            Console.WriteLine("Enter a number below:");
            string breadInput = Console.ReadLine();

            Console.WriteLine("Please enter how many pastries you want: They are $2 each and buy 3 get 1 free!");
            Console.WriteLine("Enter a number below:");
            string pastryInput = Console.ReadLine();

            int numBread = int.Parse(breadInput);
            int numPastry = int.Parse(pastryInput);

            BreadPrice breadCalculation = new BreadPrice(numBread);
            int breadCost = breadCalculation.BreadOutput();

            PastryPrice pastryCalculation = new PastryPrice(numPastry);
            int pastryCost = pastryCalculation.PastryOutput();
            int totalCost = pastryCost + breadCost;

            Console.WriteLine($"Total cost for {numBread} loaves of bread: ${breadCost}");
            Console.WriteLine($"Total cost for {numPastry} pastries: ${pastryCost}");
            Console.WriteLine($"Total cost for both: ${totalCost}");
        }
    }
}