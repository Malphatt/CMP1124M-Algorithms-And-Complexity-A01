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

        public String[] Sort(String road) { // This method returns a string array of every 10th element of the road in ascending order
            
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

            // Sorts the road in ascending order
            int[] selectedRoadInt = Array.ConvertAll(selectedRoad, int.Parse); // Convert the string array to an int array
            Array.Sort(selectedRoadInt); // Sort the int array
            selectedRoad = Array.ConvertAll(selectedRoadInt, element => element.ToString()); // Convert the int array back to a string array

            return selectedRoad;
        }

        public String[] Display10Elements(String road, bool ascending) { // This method returns a string array of every 10th element of the road in ascending or descending order

            List<String> returnRoad = new List<String>();
            String[] sortedRoad; // Sort the road in descending order
            
            if (ascending) { // If the road is to be sorted in ascending order
                sortedRoad = Sort(road); // Sort the road in ascending order
            } else { // If the road is to be sorted in descending order
                sortedRoad = Sort(road); // Sort the road in descending order
                Array.Reverse(sortedRoad); // Reverse the road (This is needed because the road is sorted in ascending order
            }

            for (int i = 0; i < sortedRoad.Length; i += 10) { // Add every 10th element to the returnRoad array
                returnRoad.Add(sortedRoad[i]);
            }

            return returnRoad.ToArray(); // Return the returnRoad array
        }

        public String[][] FindElement(String road, String searchValue) { // This method returns the location of the value in the road

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
                return new String[0][]; // Return an empty array (This should never happen but is needed to prevent errors)
            }

            List<String[]> locationList = new List<String[]>(); // Create a list to store the locations

            // Loop through the road to find the locations at which the value is found and add them to the list
            for (int location = 0; location < selectedRoad.Length; location++) {
                if (selectedRoad[location] == searchValue) {
                    String[] locationData = new String[2] {searchValue, location.ToString()};
                    locationList.Add(locationData); // Add the location to the list
                }
            }

            return locationList.ToArray(); // Convert the list to an array and return it
            // if (locationList.Count == 0) { // If the value is not found in the road
                
            // } else {

            // }
        }
    }
}