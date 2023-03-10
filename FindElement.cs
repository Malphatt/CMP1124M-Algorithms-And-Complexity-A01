namespace CMP1124M_AlgorithmsAndComplexity {

    class FindElement {

        DisplayRoads displayRoads = new DisplayRoads();

        public FindElement() { InputRoadType(); }

        void InputRoadType() {

            int roadType = 0; // This variable is used to store the road type

            bool inputRoadType = false; // This variable is used to check if the user has entered a valid road type
            while (!inputRoadType) {

                Console.Write("\nSelect a road type (1 = 256 Road, 2 = 2048 Road, 3 = Merged 256 Road, 4 = Merged 2048 Road): ");
                String? roadTypeString = Console.ReadLine();

                if (roadTypeString == null || roadTypeString == "") {

                    return;

                } else
                if (roadTypeString.ToUpper() == "Q") { // If the user wants to exit the program
                    Environment.Exit(0);
                } else {

                    // Check if the road type is a number
                    bool isNumber = int.TryParse(roadTypeString, out int number);

                    if (!isNumber) { // If the road type is not a number

                        Console.WriteLine("Invalid road type");
                        continue;

                    }
                    if (number < 1 || number > 4) { // If the road type is not between 1 and 4
                        Console.WriteLine("Invalid road type");
                        continue;
                    } else {
                        roadType = number; // Set the roadType variable to the user input
                        if (roadType == 3 || roadType == 4) { // If the road type is 3 or 4
                            InputElement(roadType, 0); // Call the inputElement method
                        } else {
                            InputRoad(roadType); // Call the InputRoad method
                        }
                    }
                }
            }
        }

        void InputRoad(int roadType) {

            int road = 0; // This variable is used to store the road number

            bool inputRoad = false; // This variable is used to check if the user has entered a valid road number
            while (!inputRoad) {

                Console.Write("\nSelect a road number (1, 2 or 3): ");
                String? roadString = Console.ReadLine();

                if (roadString == null || roadString == "") {

                    return;

                } else
                if (roadString.ToUpper() == "Q") { // If the user wants to exit the program
                    Environment.Exit(0);
                } else {

                    // Check if the road number is a number
                    bool isNumber = int.TryParse(roadString, out int number);

                    if (!isNumber) { // If the road number is not a number

                        Console.WriteLine("Invalid road number");
                        continue;

                    }
                    if (number < 1 || number > 3) { // If the road number is not between 1 and 3
                        Console.WriteLine("Invalid road number");
                        continue;
                    } else { // If the road number is between 1 and 3
                        road = number; // Set the road variable to the user input
                        InputElement(roadType, road); // Call the InputElement method
                    }
                }
            }
        }

        void InputElement(int roadType, int road) {

            bool inputElement = false; // This variable is used to check if the user has entered a valid element
            while (!inputElement) { // While the user has not entered a valid element

                Console.Write("\nEnter an element (Integer): ");
                String? element = Console.ReadLine();

                Console.WriteLine();

                if (element == null || element == "") {

                    return;

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
                    displayRoads.FindElements(3, 0, element); // Call the FindElement method
                    return;
                }
            }
        }
    }
}