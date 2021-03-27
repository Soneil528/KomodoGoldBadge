using Cafe_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Console
{
    class ProgramUI
    {
        private MenuContentRepository _menuRepo = new MenuContentRepository();

        // Method that starts the Cafe Program
        public void RunCafe()
        {
            SeedMenu();
            ManagerMenu();
        }

        private void ManagerMenu()
        {
            bool runMenu = true;
            while (runMenu)
            {
                // Display options to the manager
                Console.WriteLine("Active Manager please select an option:\n" +
                    "1. Create New Menu Item\n" +
                    "2. View All Menu Items\n" +
                    "3. View A Specific Menu Item By Meal Number\n" +
                    "4. Delete A Menu Item By Meal Number\n" +
                    "5. Exit");
                // Get the manager's input
                string input = Console.ReadLine();

                // Understand the manager's input and do what is expected
                switch (input)
                {
                    case "1":
                        // Add menu item
                        CreateNewMenuItem();
                        break;
                    case "2":
                        // View all menu items
                        DisplayAllMenuItems();
                        break;
                    case "3":
                        // View a menu item
                        DisplayMenuItemByNumber();
                        break;
                    case "4":
                        // Delete a menu item
                        DeleteMenuItem();
                        break;
                    case "5":
                        // Leave manager menu
                        Console.WriteLine("Bye!");
                        runMenu = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice, please.");
                        break;
                }

                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Add menu item
        private void CreateNewMenuItem()
        {
            Console.Clear();
            MenuContent newContent = new MenuContent();
            // Get meal number
            Console.WriteLine("Enter what the meal number is:");
            newContent.MealNumber = (MealNumber)int.Parse(Console.ReadLine());

            // Get meal name
            Console.WriteLine("Enter what the meal name is:");
            newContent.MealName = Console.ReadLine();

            // Get meal description
            Console.WriteLine("Enter what the meal description is:");
            newContent.MealDescription = Console.ReadLine();

            // Get meal ingredients
            Console.WriteLine("Enter what the meal ingredients is:");
            newContent.MealIngredients = Console.ReadLine();

            // Get meal price
            Console.WriteLine("Enter what the meal price is:");
            newContent.MealPrice = Console.ReadLine();

            _menuRepo.AddMenuContentToList(newContent);
        }

        // View all menu items
        private void DisplayAllMenuItems()
        {
            List<MenuContent> listOfContent = _menuRepo.GetMenuContentList();
           
            foreach(MenuContent content in listOfContent)
            {
                Console.WriteLine($"Number: {content.MealNumber}\n" +
                    $"Name: {content.MealName}\n" +
                    $"Description: {content.MealDescription}\n" +
                    $"Ingredients: {content.MealIngredients}\n" +
                    $"Price: {content.MealPrice}\n");
            }
        }

        // View existing menu item
        private void DisplayMenuItemByNumber()
        {
            // Get meal number from user
            Console.WriteLine("Enter the number of the meal you wish to see:");
            string mealNumber = Console.ReadLine();
            // Find menu item
            MenuContent content = _menuRepo.GetContentByMealNumber((MealNumber)int.Parse(mealNumber));
            // Show menu item if not null
            if(content != null)
            {
                Console.WriteLine($"Number: {content.MealNumber}\n" +
                    $"Name: {content.MealName}\n" +
                    $"Description: {content.MealDescription}\n" +
                    $"Ingredients: {content.MealIngredients}\n" +
                    $"Price: {content.MealPrice}\n");
            }
            else
            {
                Console.WriteLine("No menu item by that number.");
            }
        }

        // Delete menu item
        private void DeleteMenuItem()
        {
            // Show all menu items
            DisplayAllMenuItems();
            // Get number of menu item needed to delete
            Console.WriteLine("Enter the number of menu item you wish to remove: ");
            string input = Console.ReadLine();
            // Call delete method
            bool wasDeleted = _menuRepo.RemoveMenuContentFromList((MealNumber)int.Parse(input));
            // If deleted say so
            if (wasDeleted)
            {
                Console.WriteLine("The menu item was deleted.");
            }
            else
            {
                Console.WriteLine("The menu item could not be deleted.");
            }
        }

        // Seed Method
        private void SeedMenu()
        {
            MenuContent one = new MenuContent(MealNumber.One, "Number One", "Hamburger & Fries", "Quarter Pound Beef patty, Ketchup, Mustard & French Fries",
                "$10");
            _menuRepo.AddMenuContentToList(one); 
        }
    }
}
