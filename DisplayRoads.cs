namespace CMP1124M_AlgorithmsAndComplexity {

    class DisplayRoads {

        Roads roads = new Roads();

        public DisplayRoads() {}

        public void DisplayNumElements(int roadType, int road, int sortType, bool ascending) {

            String roadString = "";
            int numElements = 0;

            if (roadType == 1) { // 256 Road
                if (road == 1) { // Road 1
                    roadString = "Road_1_256";
                } else if (road == 2) { // Road 2
                    roadString = "Road_2_256";
                } else if (road == 3) { // Road 3
                    roadString = "Road_3_256";
                } else {
                    Console.WriteLine("Invalid road number");
                }
                numElements = 10;
            } else if (roadType == 2) { // 2048 Road
                if (road == 1) { // Road 1
                    roadString = "Road_1_2048";
                } else if (road == 2) { // Road 2
                    roadString = "Road_2_2048";
                } else if (road == 3) { // Road 3
                    roadString = "Road_3_2048";
                } else {
                    Console.WriteLine("Invalid road number");
                }
                numElements = 50;
            } else if (roadType == 3) { // Merged 256 Road
                roadString = "Road_256_Merged";
                numElements = 10;
            } else if (roadType == 4) { // Merged 2048 Road
                roadString = "Road_2048_Merged";
                numElements = 50;
            } else {
                Console.WriteLine("Invalid road type");
            }

            Console.WriteLine("Displaying every " + numElements + "th element in the sorted " + roadString + " road");

            foreach (String element in roads.DisplayNumElements(roadString, ascending, sortType, numElements)) {
                Console.WriteLine(element);
            }

        }

        public void FindElements(int roadType, int road, int searchType, String element) {

            String roadString = "";

            if (roadType == 1) { // 256 Road
                if (road == 1) { // Road 1
                    roadString = "Road_1_256";
                } else if (road == 2) { // Road 2
                    roadString = "Road_2_256";
                } else if (road == 3) { // Road 3
                    roadString = "Road_3_256";
                } else {
                    Console.WriteLine("Invalid road number");
                }
            } else if (roadType == 2) { // 2048 Road
                if (road == 1) { // Road 1
                    roadString = "Road_1_2048";
                } else if (road == 2) { // Road 2
                    roadString = "Road_2_2048";
                } else if (road == 3) { // Road 3
                    roadString = "Road_3_2048";
                } else {
                    Console.WriteLine("Invalid road number");
                }
            } else if (roadType == 3) { // Merged 256 Road
                roadString = "Road_256_Merged";
            } else if (roadType == 4) { // Merged 2048 Road
                roadString = "Road_2048_Merged";
            } else {
                Console.WriteLine("Invalid road type");
            }

                
            String[][] foundElement = roads.FindElements(roadString, searchType, element); // Call the FindElement method
                    
            foreach (String[] elementLocation in foundElement) { // Display the locations of the element(s)
                if (elementLocation[0] != "") {
                    if (elementLocation[0] == "SearchInfo") {
                        Console.WriteLine("  " + elementLocation[1]);
                    } else {
                        Console.WriteLine("  Element: " + elementLocation[0] + " | Found At Location: " + elementLocation[1]);
                    }
                } else {
                    Console.WriteLine();
                }
            }
        }
    }
}