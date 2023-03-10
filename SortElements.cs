namespace CMP1124M_AlgorithmsAndComplexity {

    class SortElements {

        DisplayRoads displayRoads = new DisplayRoads();

        public SortElements() { InputRoadType(); }

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
                            InputSortType(roadType, 0); // Call the inputElement method
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

                    // Check if the road is a number
                    bool isNumber = int.TryParse(roadString, out int number);

                    if (!isNumber) { // If the road is not a number

                        Console.WriteLine("Invalid road");
                        continue;

                    }
                    if (number < 1 || number > 3) { // If the road is not between 1 and 3
                        Console.WriteLine("Invalid road");
                        continue;
                    } else {
                        road = number; // Set the road variable to the user input
                        InputSortType(roadType, road); // Call the InputSortType method
                    }
                }
            }
        }

        void InputSortType(int roadType, int road) {

            int sortType = 0; // This variable is used to store the sort type

            bool inputSortType = false; // This variable is used to check if the user has entered a valid sort type
            while (!inputSortType) {

                Console.Write("\nSelect a sort type (1 = Bubble Sort, 2 = Insertion Sort, 3 = Merge Sort, 4 = Quick Sort): ");
                String? sortTypeString = Console.ReadLine();

                if (sortTypeString == null || sortTypeString == "") {

                    return;

                } else
                if (sortTypeString.ToUpper() == "Q") { // If the user wants to exit the program
                    Environment.Exit(0);
                } else {

                    // Check if the sort type is a number
                    bool isNumber = int.TryParse(sortTypeString, out int number);

                    if (!isNumber) { // If the sort type is not a number

                        Console.WriteLine("Invalid sort type");
                        continue;

                    }
                    if (number < 1 || number > 4) { // If the sort type is not between 1 and 4
                        Console.WriteLine("Invalid sort type");
                        continue;
                    } else {
                        sortType = number; // Set the sortType variable to the user input
                        InputDisplayOrder(roadType, road, sortType); // Call the InputDisplayOrder method
                    }
                }
            }
        }

        void InputDisplayOrder(int roadType, int road, int sortType) {

            bool inputDisplayOrder = false; // This variable is used to check if the user has entered a valid display order
            while (!inputDisplayOrder) {

                Console.Write("\nSelect a display order (1 = Ascending, 2 = Descending): ");
                String? displayOrderString = Console.ReadLine();

                Console.WriteLine();

                if (displayOrderString == null || displayOrderString == "") {

                    return;

                } else
                if (displayOrderString.ToUpper() == "Q") { // If the user wants to exit the program
                    Environment.Exit(0);
                } else {

                    // Check if the display order is a number
                    bool isNumber = int.TryParse(displayOrderString, out int number);

                    if (!isNumber) { // If the display order is not a number

                        Console.WriteLine("Invalid display order");
                        continue;

                    }

                    bool asc; // This variable is used to store the display order

                    if (number == 1) { // If the display order is 1
                        asc = true; // Set the asc variable to true
                    } else
                    if (number == 2) { // If the display order is 2
                        asc = false; // Set the asc variable to false
                    } else { // If the display order is not 1 or 2
                        Console.WriteLine("Invalid display order");
                        continue;
                    }
                    displayRoads.DisplayNumElements(roadType, road, sortType, asc); // Call the DisplayRoad method
                    return;
                }
            }
        }
    }
}