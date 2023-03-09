namespace CMP1124M_OOP {

    class Program {

        // Create a new instance of the Roads class
        static Roads roads = new Roads();

        static void Main(string[] args) {

        // 256 Roads
            // Display the 10th element of each 256 road in ascending order
            Console.WriteLine("\nDisplaying each 10th element of: Road_1_256 in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_1_256", true, 10)) {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nDisplaying each 10th element of: Road_2_256 in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_2_256", true, 10)) {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nDisplaying each 10th element of: Road_3_256 in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_3_256", true, 10)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Display the 10th element of each 256 road in descending order
            Console.WriteLine("\nDisplaying each 10th element of: Road_1_256 in descending order");
            foreach (String element in roads.DisplayNumElements("Road_1_256", false, 10)) {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nDisplaying each 10th element of: Road_2_256 in descending order");
            foreach (String element in roads.DisplayNumElements("Road_2_256", false, 10)) {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nDisplaying each 10th element of: Road_3_256 in descending order");
            foreach (String element in roads.DisplayNumElements("Road_3_256", false, 10)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();


        // 2048 Roads
            // Display the 50th element of each 2048 road in ascending order
            Console.WriteLine("\nDisplaying each 50th element of: Road_1_2048 in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_1_2048", true, 50)) {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nDisplaying each 50th element of: Road_2_2048 in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_2_2048", true, 50)) {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nDisplaying each 50th element of: Road_3_2048 in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_3_2048", true, 50)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Display the 50th element of each 2048 road in descending order
            Console.WriteLine("\nDisplaying each 50th element of: Road_1_2048 in descending order");
            foreach (String element in roads.DisplayNumElements("Road_1_2048", false, 50)) {
                Console.WriteLine(element);
            }
            Console.WriteLine("\nDisplaying each 50th element of: Road_2_2048 in descending order");
            foreach (String element in roads.DisplayNumElements("Road_2_2048", false, 50)) {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nDisplaying each 50th element of: Road_3_2048 in descending order");
            foreach (String element in roads.DisplayNumElements("Road_3_2048", false, 50)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();


        // Merged 256 Road
            // Display the 10th element of the Merged 256 road in ascending order
            Console.WriteLine("\nDisplaying each 10th element of: Road_1_256 and Road_2_256 merged together in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_256_Merged", true, 10)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Display the 10th element of the Merged 256 road in descending order
            Console.WriteLine("\nDisplaying each 10th element of: Road_1_256 and Road_2_256 merged together in descending order");
            foreach (String element in roads.DisplayNumElements("Road_256_Merged", false, 10)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();


        // Merged 2048 Road 
            // Display the 10th element of the Merged 2048 road in ascending order
            Console.WriteLine("\nDisplaying each 10th element of: Road_1_2048 and Road_2_2048 merged together in ascending order");
            foreach (String element in roads.DisplayNumElements("Road_2048_Merged", true, 10)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Display the 10th element of the Merged 2048 road in descending order
            Console.WriteLine("\nDisplaying each 10th element of: Road_1_2048 and Road_2_2048 merged together in descending order");
            foreach (String element in roads.DisplayNumElements("Road_2048_Merged", false, 10)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            Console.WriteLine("Press ENTER to go back at any point or type 'Q' to exit the program");

            inputRoad();

        }



        static void inputRoad() { // Display the location of a user-defined element in a user-defined road
            
            bool inputRoad = false; // This variable is used to check if the user has entered a valid road name
            while (!inputRoad) { // While the user has not entered a valid road name

                Console.Write("\nEnter a road name: ");
                String? road = Console.ReadLine();

                if (road == null || road == "") {

                    Console.WriteLine("Invalid road name");
                    continue;

                } else
                if (road.ToUpper() == "Q") { // If the user wants to exit the program
                    Environment.Exit(0);
                } else
                if (road == "Road_1_256" || road == "Road_1_2048" || road == "Road_2_256" || road == "Road_2_2048" || road == "Road_3_256" || road == "Road_3_2048" || road == "Road_256_Merged" || road == "Road_2048_Merged") { // If the road name is valid
                    
                    inputRoad = true; // Set the inputRoad variable to true
                    findElement(road); // Call the findElement method
                    
                } else { // If the road name is invalid
                    Console.WriteLine("Invalid road name");
                }
            }
        }

        static void findElement(String road) {
                
            bool inputElement = false; // This variable is used to check if the user has entered a valid element
            while (!inputElement) { // While the user has not entered a valid element

                Console.Write("Enter an element: ");
                String? element = Console.ReadLine();

                Console.WriteLine();

                if (element == null || element == "") {

                    Console.WriteLine("Invalid element");
                    inputRoad(); // Go back to the inputRoad method

                } else
                if (element.ToUpper() == "Q") { // If the user wants to exit the program
                    Environment.Exit(0);
                } else {

                    // Check if the element is a number
                    bool isNumber = int.TryParse(element, out int number);

                    if (!isNumber) { // If the element is not a number

                        Console.WriteLine("Invalid element");
                            continue;

                    }

                    inputElement = true; // Set the inputElement variable to true
                    String[][] foundElement = roads.FindElements(road, element); // Call the FindElement method
                    
                    if (foundElement.Length == 0) { // If the element was not found

                        Console.WriteLine("Element not found"); // Display an error message
                        continue;
                        
                    } else { // If the element was found
                        foreach (String[] elementLocation in foundElement) { // Display the location of the element
                            if (elementLocation[0] != "") {
                                Console.WriteLine("  Element: " + elementLocation[0] + " | Found At Location: " + elementLocation[1]);
                            } else {
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            inputRoad(); // Loop until the user exits the program
        }
    }
}