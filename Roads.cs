namespace CMP1124M_OOP {

    class Roads {

        String[] Road_1_256; // This is the string array that stores the contents of Road_1_256.txt
        public String[] _Road_1_256 {
            get { return Road_1_256; }
            set { Road_1_256 = value; }
        }

        String[] Road_2_256; // This is the string array that stores the contents of Road_2_256.txt
        public String[] _Road_2_256 {
            get { return Road_2_256; }
        }

        String[] Road_3_256; // This is the string array that stores the contents of Road_3_256.txt
        public String[] _Road_3_256 {
            get { return Road_3_256; }
        }

        public Roads() { // This constructor reads the road files and stores them in the string arrays
            Road_1_256 = System.IO.File.ReadAllLines("Roads/Road_1_256.txt");
            Road_2_256 = System.IO.File.ReadAllLines("Roads/Road_2_256.txt");
            Road_3_256 = System.IO.File.ReadAllLines("Roads/Road_3_256.txt");
        }

        public String[] Display10SortAscending(String road) { // This method returns a string array of every 10th element of the road in ascending order
            
            if (road == "Road_1_256") { // If the road is Road_1_256

                String[] sortedRoad = _Road_1_256;
                String[] returnRoad = new String[_Road_1_256.Length / 10];
                
                Array.Sort(sortedRoad); // Sort the road

                for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                    returnRoad[i / 10] = sortedRoad[i];
                }

                return returnRoad;
            } else
            if (road == "Road_2_256") { // If the road is Road_2_256

                String[] sortedRoad = _Road_2_256;
                String[] returnRoad = new String[_Road_2_256.Length / 10];

                Array.Sort(sortedRoad); // Sort the road

                for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                    returnRoad[i / 10] = sortedRoad[i];
                }

                return returnRoad;

            } else
            if (road == "Road_3_256") { // If the road is Road_3_256

                String[] sortedRoad = _Road_3_256;
                String[] returnRoad = new String[_Road_3_256.Length / 10];

                Array.Sort(sortedRoad); // Sort the road

                for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                    returnRoad[i / 10] = sortedRoad[i];
                }

                return returnRoad;

            } else { // If the road name is invalid
                Console.WriteLine("Invalid road name");
                return new String[0];
            }
        }

        public String[] Display10SortDescending(String road) { // This method returns a string array of every 10th element of the road in descending order

            if (road == "Road_1_256") { // If the road is Road_1_256

                String[] sortedRoad = _Road_1_256;
                String[] returnRoad = new String[_Road_1_256.Length / 10];

                Array.Sort(sortedRoad);     // Sort the road
                Array.Reverse(sortedRoad);  // Reverse the road

                for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                    returnRoad[i / 10] = sortedRoad[i];
                }

                return returnRoad;

            } else
            if (road == "Road_2_256") { // If the road is Road_2_256

                String[] sortedRoad = _Road_2_256;
                String[] returnRoad = new String[_Road_2_256.Length / 10];

                Array.Sort(sortedRoad);     // Sort the road
                Array.Reverse(sortedRoad);  // Reverse the road

                for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                    returnRoad[i / 10] = sortedRoad[i];
                }

                return returnRoad;

            } else
            if (road == "Road_3_256") { // If the road is Road_3_256

                String[] sortedRoad = _Road_3_256;
                String[] returnRoad = new String[_Road_3_256.Length / 10];

                Array.Sort(sortedRoad);     // Sort the road
                Array.Reverse(sortedRoad);  // Reverse the road

                for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                    returnRoad[i / 10] = sortedRoad[i];
                }

                return returnRoad;

            } else { // If the road name is invalid
                Console.WriteLine("Invalid road name");
                return new String[0];
            }
        }
    }
}