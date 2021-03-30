using Claims_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Console
{
    class ProgramUI
    {
        private ClaimsContentRepository _claimsContentRepo = new ClaimsContentRepository();

        public void RunClaims()
        {
            SeedContent();
            ClaimsMenu();
        }

        // Menu
        private void ClaimsMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
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
                switch (input)
                {
                    case "1":
                        // See claims
                        DisplayAllClaims();
                        break;
                    case "2":
                        // Next claim
                        NextClaim();
                        break;
                    case "3":
                        // Enter a claim
                        NewClaim();
                        break;
                    case "4":
                        // Exit menu
                        Console.WriteLine("Bye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Show all claims
        private void DisplayAllClaims()
        {
            List<ClaimsContent> listOfClaimsContent = _claimsContentRepo.GetClaimsContentsList();
            foreach (ClaimsContent content in listOfClaimsContent)
            {
                Console.WriteLine($"ClaimID: {content.ClaimID}\n" +
                    $"Type: {content.TypeOfClaim}\n" +
                    $"Description: {content.ClaimDescription}\n" +
                    $"Amount: {content.ClaimAmount}\n" +
                    $"Incident date: {content.DateOfIncident}\n" +
                    $"Claim date: {content.DateOfClaim}\n" +
                    $"Claim is valid: {content.IsValid}\n");
            }
        }

        // Next claim
        private void NextClaim()
        {

        }

        // Enter a claim
        private void NewClaim()
        {
            Console.Clear();
            ClaimsContent newContent = new ClaimsContent();

            // Get claim ID
            Console.WriteLine("Enter the claim ID number:");
            newContent.ClaimID = Console.ReadLine();

            // Get type of claim
            Console.WriteLine("Enter the claim type: 1 = Car, 2 = Home, 3 = Theft");
            newContent.TypeOfClaim = (ClaimType)int.Parse(Console.ReadLine());

            // Get claim description
            Console.WriteLine("Enter the claim description:");
            newContent.ClaimDescription = Console.ReadLine();

            // Get claim Amount
            Console.WriteLine("Enter the claim amount:");
            newContent.ClaimAmount = int.Parse(Console.ReadLine());

            // Get date of claim incident
            Console.WriteLine("Enter the date of the incident:");
            newContent.DateOfIncident = DateTime.Parse(Console.ReadLine());

            // Get date of the claim
            Console.WriteLine("Enter the date of the claim:");
            newContent.DateOfClaim = DateTime.Parse(Console.ReadLine());

            IsClaimValid(newContent.ClaimID)

            _claimsContentRepo.AddClaimsContentToList(newContent);
        }

        private bool IsClaimValid(ClaimsContent content)
        {
            {   
                int dateDiff = (content.DateOfClaim.Date - content.DateOfIncident.Date).Days;
                if (dateDiff <= 30)
                {
                    return true;
                }
            }
                return false;
        }
        
        
        // Seed Method
        private void SeedContent()
        {
            ClaimsContent one = new ClaimsContent("1", ClaimType.Car, "Accident on 465.", 400,
                DateTime.Parse("4 / 25 / 18"), DateTime.Parse("4 / 27 / 18"), false);
            ClaimsContent two = new ClaimsContent("2", ClaimType.Home, "House fire in kitchen.", 4000,
                DateTime.Parse("4 / 11 / 18"), DateTime.Parse("4 / 12 / 18"), false);
            ClaimsContent three = new ClaimsContent("3", ClaimType.Theft, "Stolen pancakes.", 4,
                DateTime.Parse("4 / 27 / 18"), DateTime.Parse("6 / 01 / 18"), false);

            one.IsValid = IsClaimValid(one);
            two.IsValid = IsClaimValid(two);
            three.IsValid = IsClaimValid(three);

            _claimsContentRepo.AddClaimsContentToList(one);
            _claimsContentRepo.AddClaimsContentToList(two);
            _claimsContentRepo.AddClaimsContentToList(three);
        }
    }

}


