namespace CMP1124M_AlgorithmsAndComplexity {

    class Search {

        String[] selectedRoad;
        int[] encodedArray;

        int searchedElements;
        public int SearchedElements { get { return searchedElements; } }


        public Search(String[] selectedRoad) {

            this.selectedRoad = selectedRoad;
            encodedArray = new int[selectedRoad.Length];
            searchedElements = 0;

        }

        // =========================
        // ===== Linear Search =====
        // =========================
        //
        // Description:
        //     Also known as sequential search,
        //     this algorithm searches the road 1 element at a time in the order in which they appear
        //
        // Time Complexity:
        //     Best Case: O(1)
        //     Worst Case: O(n)
        //     Average Case: O(n)
        //
        // Space Complexity:
        //     Worst Case: O(n) {iterative}
        //
        // Source:
        //     https://en.wikipedia.org/wiki/Linear_search
        //
        // =========================
        
        public String[][] LinearSearch(String searchValue) {

            List<String[]> locationList = new List<String[]>(); // Create a list to store the locations

            // Loop through the road to find the locations at which the value is found and add them to the list
            for (int location = 0; location < selectedRoad.Length; location++) {
                if (selectedRoad[location] == searchValue) {
                    String[] locationData = new String[2] {searchValue, (location + 1).ToString()};
                    locationList.Add(locationData); // Add the location to the list
                }
            }
            return locationList.ToArray(); // Convert the list to an array and return it
        }

        // =========================
        // ===== Binary Search =====
        // =========================
        //
        // Description:
        //     This algorithm searches the road by repeatedly dividing the search interval in half
        //
        // Time Complexity:
        //     Best Case: O(1)
        //     Worst Case: O(log n)
        //     Average Case: O(log n)
        //
        // Space Complexity:
        //     Worst Case: O(n)
        //
        // Source:
        //     https://en.wikipedia.org/wiki/Binary_search_algorithm
        //
        // =========================
        public String[][] BinarySearch(int searchValue) {

            // Sort the road and the array of locations
            int[] SortedArray = InsertionSortEncoder();

            List<String[]> locationList = new List<String[]>(); // Create a list to store the locations

            int low = 0;
            int high = selectedRoad.Length - 1;

            while (low <= high) {

                int mid = (low + high) / 2;

                if (SortedArray[mid] == searchValue) {

                    // Add the location to the list
                    String[] locationData = new String[2] {searchValue.ToString(), (encodedArray[mid] + 1).ToString()};
                    locationList.Add(locationData);

                    // Search for the next location
                    int nextLocation = mid + 1;
                    while (nextLocation < selectedRoad.Length && SortedArray[nextLocation] == searchValue) {
                        locationData = new String[2] {searchValue.ToString(), (encodedArray[nextLocation] + 1).ToString()};
                        locationList.Add(locationData);
                        nextLocation++;
                    }

                    // Search for the previous location
                    int previousLocation = mid - 1;
                    while (previousLocation >= 0 && SortedArray[previousLocation] == searchValue) {
                        locationData = new String[2] {searchValue.ToString(), (encodedArray[previousLocation] + 1).ToString()};
                        locationList.Add(locationData);
                        previousLocation--;
                    }

                    break;
                }
                else if (SortedArray[mid] < searchValue) {
                    low = mid + 1;
                }
                else {
                    high = mid - 1;
                }
            }
            return PostBinarySearchSort(locationList.ToArray()); // Order the locations and return the list as an array
        }

        // Performs a simple Insertion Sort on the road and an array of the locations at which the value will be found
        int[] InsertionSortEncoder() {

            for (int i = 0; i < selectedRoad.Length; i++) {
                encodedArray[i] = i; // Populate the array with the locations of the values
            }

            int[] selectedRoadInt = Array.ConvertAll(selectedRoad, int.Parse); // Convert the string array to an int array

            for (int i = 1; i < selectedRoadInt.Length; i++) {

                int j = i;

                while (j > 0 && selectedRoadInt[j - 1] > selectedRoadInt[j]) {

                    int temp = selectedRoadInt[j];
                    int temp2 = encodedArray[j];

                    selectedRoadInt[j] = selectedRoadInt[j - 1];
                    selectedRoadInt[j - 1] = temp;

                    encodedArray[j] = encodedArray[j - 1];
                    encodedArray[j - 1] = temp2;

                    j--;

                }
            }

            return selectedRoadInt;
        }

        // Performs a simple Insertion Sort on the location list so that the locations are in ascending order
        String[][] PostBinarySearchSort(String[][] locationList) {
    
            int[] sortedLocationList = new int[locationList.Length];

            // Add the locations to the list
            for (int i = 0; i < locationList.Length; i++) {
                sortedLocationList[i] = Int32.Parse(locationList[i][1]);
            }

            for (int i = 1; i < sortedLocationList.Length; i++) {

                int j = i;

                while (j > 0 && sortedLocationList[j - 1] > sortedLocationList[j]) {

                    int temp = sortedLocationList[j];
                    String[] temp2 = locationList[j];

                    sortedLocationList[j] = sortedLocationList[j - 1];
                    sortedLocationList[j - 1] = temp;

                    locationList[j] = locationList[j - 1];
                    locationList[j - 1] = temp2;

                    j--;

                }
            }

            return locationList;
        }
    }
}