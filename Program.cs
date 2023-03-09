namespace CMP1124M_OOP {

    class Program {

        // Create a new instance of the Roads class
        static Roads roads = new Roads();

        static void Main(string[] args) {

            // Display the 10th element of each road in ascending order
            foreach (String element in roads.Display10Elements("Road_1_256", true)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10Elements("Road_2_256", true)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10Elements("Road_3_256", true)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Display the 10th element of each road in descending order
            foreach (String element in roads.Display10Elements("Road_1_256", false)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10Elements("Road_2_256", false)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10Elements("Road_3_256", false)) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            inputRoad();

        }

        static void inputRoad() { // Display the location of a user-defined element in a user-defined road
            
            bool inputRoad = false; // This variable is used to check if the user has entered a valid road name
            while (!inputRoad) { // While the user has not entered a valid road name

                Console.Write("Enter a road name: ");
                String? road = Console.ReadLine();

                if (road == null || road == "") {

                    Console.WriteLine("Invalid road name");
                    continue;

                } else
                if (road == "Road_1_256" || road == "Road_2_256" || road == "Road_3_256") { // If the road name is valid
                    
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
    
                    if (element == null || element == "") {
    
                        Console.WriteLine("Invalid element");
                        continue;
    
                    } else {
                        inputElement = true; // Set the inputElement variable to true
                        String[] foundElement = roads.FindElement(road, element); // Call the FindElement method
                        if (foundElement.Length == 0) { // If the element was not found

                            Console.WriteLine("Element not found"); // Display an error message
                            continue;
                            
                        } else {
                            foreach (String elementLocation in foundElement) { // Display the location of the element
                                Console.WriteLine("Element: " + element + " | Found At Location: " + elementLocation);
                            }
                        }
                    }
                }
        }
    }
}