using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Console
{
    class ProgramUI
    {   
        public void RunClaims()
        {
            ClaimsMenu();
        }

        // Menu
        private void ClaimsMenu()
        {
            // Display Options
            Console.WriteLine("Select an option:\n" +
                "1. See all claims\n" +
                "2. Take care of next claim\n" +
                "3. Enter a new claim\n" +
                "4. Exit");

            // Get input
            string input = Console.ReadLine();

            // Evaluate input and act
            switch(input)
            {
                case "1":
                    // See claims
                    break;
                case "2":
                    // Next claim
                    break;
                case "3":
                    // Enter a claim
                    break;
                case "4":
                    // Exit menu
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    break;
            }

        }
    }
}
