namespace CMP1124M_AlgorithmsAndComplexity {

    class Program {
        


        static void Main(string[] args) {

            Console.WriteLine("\nWelcome to the CMP1124M Algorithms and Complexity Assignment 1 Program\n");
            Console.WriteLine("This program will allow you to sort and search for traffic data elements in a road");
            Console.WriteLine("Road data is stored in a text file and will be read into the program");
            Console.WriteLine("The program will then allow you to sort the data in ascending or descending order");
            Console.WriteLine("You can also search for a specific element in the road");
            Console.WriteLine("\nPress ENTER to go back at any point or type 'Q' to exit the program\n");

        
        // Gets the user input of what they want to do
            bool exit = false;
            while (!exit) {
                
                Console.Write("\nWould you like to sort a road or find an element in a road? (1 or 2): ");
                String? input = Console.ReadLine();
                
                if (input == null || input == "") {
                    
                    Console.WriteLine("You may not go back at this point, although you can enter 'Q' to exit the program\n");
                    continue;
                    
                } else
                if (input.ToUpper() == "Q") { // If the user wants to exit the program
                    Environment.Exit(0);
                } else {
                        
                    // Check if the input is a number
                    bool isNumber = int.TryParse(input, out int number);
                    
                    if (!isNumber) { // If the input is not a number
                        
                        Console.WriteLine("Invalid input\n");
                        continue;
                        
                    }
                    if (number < 1 || number > 2) { // If the input is not between 1 and 2
                        Console.WriteLine("Invalid input\n");
                        continue;
                    } else {
                        if (number == 1) { // If the user wants to sort a road
                            new SortElements();
                        } else { // If the user wants to find an element in a road
                            new FindElement();
                        }
                    }
                }
            }
        }
    }
}