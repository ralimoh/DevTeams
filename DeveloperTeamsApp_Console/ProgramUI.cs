using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developer;
using DevTeam;

namespace DeveloperTeamsApp_Console
{
    class ProgramUI
    { // Method that runs/starts the application

        public DeveloperRepo _contentRepo = new DeveloperRepo();
       

        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                // Display our options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                // Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        createNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View Content By Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        // Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // Create new devTeamsProject
        private void createNewContent()
        {
            DevTeamPoco newContent = new DevTeamPoco();

            //TeamName
            Console.WriteLine("Enter the team name:");
            newContent.TeamName = Console.ReadLine();

            //TeamID
            Console.WriteLine("Enter the team ID:");
            newContent.TeamID = int.Parse(Console.ReadLine());
        }
        //View Current StreamingContent that is saved
        private void DisplayAllContent()
        {

        }
        //View existing Content by title
        private void DisplayContentByTitle()
        {

        }
        //Update Existing Content
        private void UpdateExistingContent()
        {
            // Display all content
            DisplayAllContent();

            // Ask for the title of the content to update
            Console.WriteLine("Enter the title of the content you'd like to update:");

            // Get that title
            string oldTitle = Console.ReadLine();

            // We will build a new object

        }
        //Delete Existing Content
        private void DeleteExistingContent()
        {
            DisplayAllContent();

            // Get the title they want to remove
            Console.WriteLine("Enter the title of the developer you'd like to remove");

            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            // If the content was deleted, say so
            //Otherwise state it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }

            // Otherwise state it could not be deleted

        }
    }
}
