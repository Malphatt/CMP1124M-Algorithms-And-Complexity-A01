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

        public String[] SortAsc(String road) { // This method returns a string array of every 10th element of the road in ascending order
            
            String[] selectedRoad;

            if (road == "Road_1_256") { // If the road is Road_1_256
                selectedRoad = _Road_1_256;
            } else
            if (road == "Road_2_256") { // If the road is Road_2_256
                selectedRoad = _Road_2_256;
            } else
            if (road == "Road_3_256") { // If the road is Road_3_256
                selectedRoad = _Road_3_256;
            } else {
                return new String[0]; // Return an empty array
            }

            Array.Sort(selectedRoad); // Sort the road

            return selectedRoad;
        }

        String[] SortDesc(String road) { // This method returns a string array of every 10th element of the road in descending order
            
            String[] selectedRoad;

            if (road == "Road_1_256") { // If the road is Road_1_256
                selectedRoad = _Road_1_256;
            } else
            if (road == "Road_2_256") { // If the road is Road_2_256
                selectedRoad = _Road_2_256;
            } else
            if (road == "Road_3_256") { // If the road is Road_3_256
                selectedRoad = _Road_3_256;
            } else {
                return new String[0]; // Return an empty array
            }

            String[] sortedRoad = SortAsc(road); // Sort the road in ascending order
            Array.Reverse(sortedRoad);  // Reverse the road

            return sortedRoad;
        }

        public String[] Display10Elements(String road, bool ascending) { // This method returns a string array of every 10th element of the road in ascending or descending order

            List<String> returnRoad = new List<String>();
            String[] sortedRoad; // Sort the road in descending order
            
            if (ascending) { // If the road is to be sorted in ascending order
                sortedRoad = SortAsc(road); // Sort the road in ascending order
            } else { // If the road is to be sorted in descending order
                sortedRoad = SortDesc(road); // Sort the road in descending order
            }

            for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                returnRoad.Add(sortedRoad[i]);
            }

            return returnRoad.ToArray();
        }

        public String[] FindElement(String road, String searchValue) { // This method returns the location of the value in the road

            if (road == "Road_1_256") { // If the road is Road_1_256

                List<String> locationList = new List<String>(); // Create a list to store the locations

                // Loop through the road to find the locations at which the value is found and add them to the list
                for (int location = 0; location < _Road_1_256.Length; location++) {
                    if (_Road_1_256[location] == searchValue) {
                        locationList.Add(location.ToString()); // Add the location to the list
                    }
                }

                return locationList.ToArray(); // Convert the list to an array and return it

            } else
            if (road == "Road_2_256") { // If the road is Road_2_256

                List<String> locationList = new List<String>(); // Create a list to store the locations

                // Loop through the road to find the locations at which the value is found and add them to the list
                for (int location = 0; location < _Road_2_256.Length; location++) {
                    if (_Road_2_256[location] == searchValue) {
                        locationList.Add(location.ToString()); // Add the location to the list
                    }
                }

                return locationList.ToArray(); // Convert the list to an array and return it

            } else
            if (road == "Road_3_256") { // If the road is Road_3_256

                List<String> locationList = new List<String>(); // Create a list to store the locations

                // Loop through the road to find the locations at which the value is found and add them to the list
                for (int location = 0; location < _Road_3_256.Length; location++) {
                    if (_Road_3_256[location] == searchValue) {
                        locationList.Add(location.ToString()); // Add the location to the list
                    }
                }

                return locationList.ToArray(); // Convert the list to an array and return it

            } else { // If the road name is invalid
                Console.WriteLine("Invalid road name");
                return new String[0]; // Return an empty array
            }
        }
    }
}