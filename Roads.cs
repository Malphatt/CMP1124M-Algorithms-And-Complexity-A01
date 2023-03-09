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

        String[][] getLocationArray(String[] selectedRoad, String searchValue) {
            
            List<String[]> locationList = new List<String[]>(); // Create a list to store the locations

            // Loop through the road to find the locations at which the value is found and add them to the list
            for (int location = 0; location < selectedRoad.Length; location++) {
                if (selectedRoad[location] == searchValue) {
                    String[] locationData = new String[2] {searchValue, (location + 1).ToString()};
                    locationList.Add(locationData); // Add the location to the list
                }
            }
            return  locationList.ToArray(); // Convert the list to an array and return it
        }

        bool findElement(String[] selectedRoad, String searchValue) {

            for (int i = 0; i < selectedRoad.Length; i++) { // Loop through the road to find the value
                if (selectedRoad[i] == searchValue) {
                    return true; // Return true if the value is found
                }
            }

            return false;
        }
        
        public String[][] FindElements(String road, String searchValue) { // This method returns the location of the value in the road

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

            String[][] locationArray = getLocationArray(selectedRoad, searchValue); // Get the location of the value in the road

            if (locationArray.Length == 0) { // If the value is not found in the road

                return FindElementsEmpty(selectedRoad, searchValue); // Find the next closest value in the road

            } else {
                return locationArray; // Convert the list to an array and return it
            }
        }

        String[][] FindElementsEmpty(String[] selectedRoad, String searchValue) { // This method returns the location of the value in the road
            
            bool found = false; // This is used to determine if the next closest value is found in the road
            int incrementValue = 1; // This is the value that is added to the search value to find the next closest value
            
            while (!found) {

                String newSearchValueBefore = (int.Parse(searchValue) - incrementValue).ToString(); // The next closest value
                String newSearchValueAfter = (int.Parse(searchValue) + incrementValue).ToString(); // The next closest value

                if (!findElement(selectedRoad, newSearchValueBefore) && !findElement(selectedRoad, newSearchValueAfter)) { // If the next closest value is not found in the road
                    
                    incrementValue++; // Increase the increment value

                } else { // The next closest value is found in the road

                    found = true;
                    List<String[]> locationList = new List<String[]>(); // Create a list to store the locations

                    // If the next closest value is found in the road before and after the search value
                    if (findElement(selectedRoad, newSearchValueBefore) && findElement(selectedRoad, newSearchValueAfter)) {

                        // Get the locations of the closest value before and after the search value
                        String[][] locationArrayBefore = getLocationArray(selectedRoad, newSearchValueBefore);
                        String[][] locationArrayAfter = getLocationArray(selectedRoad, newSearchValueAfter);

                        // Join the two arrays together
                        String[][] locationArray = new String[locationArrayBefore.Length + 1 + locationArrayAfter.Length][]; // Create a new array to store the locations
                        
                        locationArrayBefore.CopyTo(locationArray, 0); // Copy the locations after the search value to the new array
                        locationArray[locationArrayBefore.Length] = new String[2] {"", ""}; // Adds a blank line to the array
                        locationArrayAfter.CopyTo(locationArray, locationArrayBefore.Length + 1); // Copy the locations before the search value to the new array

                        return locationArray; // Return the array

                    } else
                    // If the next closest value is found in the road after the search value
                    if (findElement(selectedRoad, newSearchValueBefore)) {

                        return getLocationArray(selectedRoad, newSearchValueBefore); // Get the locations of the closest value after the search value

                    } else
                    // If the next closest value is found in the road before the search value
                    if (findElement(selectedRoad, newSearchValueAfter)) {

                        // Get the locations of the closest value before the search value
                        return getLocationArray(selectedRoad, newSearchValueAfter);

                    }
                }
            }
            return new String[0][]; // Return an empty array (This should never happen but is needed to prevent errors)
        }
    }
}