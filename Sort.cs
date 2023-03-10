namespace CMP1124M_AlgorithmsAndComplexity {

    class Sort {

        // Used Encapsulation to ensure steps are not changed by the user
        int steps;
        public int Steps { get { return steps; } }

        String[] selectedRoad;

        public Sort(String[] selectedRoad) {

            this.selectedRoad = selectedRoad;
            steps = 0;
        }

        // =======================
        // ===== Bubble Sort =====
        // =======================
        //
        // Description:
        //     Bubble sort is an in-place algorithm that iterates through the array
        //     and swaps adjacent elements if they are in the wrong order.
        //
        // Time Complexity:
        //     Best Case: O(n)
        //     Average Case: O(n^2)
        //     Worst Case: O(n^2)
        //
        // Space Complexity:
        //     O(1)
        //
        // Notes:
        //     Bubble sort is the simplest sorting algorithm that works by repeatedly
        //     swapping the adjacent elements if they are in wrong order.
        //
        //     Bubble sort is not efficient for large data sets.
        //
        // Source:
        //     https://en.wikipedia.org/wiki/Bubble_sort
        //
        // =======================
        public String[] BubbleSort(bool ascending) {
                
                // Sorts the road in ascending order
                int[] selectedRoadInt = Array.ConvertAll(selectedRoad, int.Parse); // Convert the string array to an int array
    
                if (ascending) { // Sorts the road in ascending order
                    // Perform a bubble sort on the array
                    for (int i = 0; i < selectedRoadInt.Length; i++) {

                        for (int j = 0; j < selectedRoadInt.Length - 1; j++) {

                            if (selectedRoadInt[j] > selectedRoadInt[j + 1]) {

                                int temp = selectedRoadInt[j];

                                selectedRoadInt[j] = selectedRoadInt[j + 1];
                                selectedRoadInt[j + 1] = temp;

                                steps++;
                            }
                        }
                    }
                } else { // Sorts the road in descending order
                    // Perform a bubble sort on the array
                    for (int i = 0; i < selectedRoadInt.Length; i++) {

                        for (int j = 0; j < selectedRoadInt.Length - 1; j++) {

                            if (selectedRoadInt[j] < selectedRoadInt[j + 1]) {

                                int temp = selectedRoadInt[j];

                                selectedRoadInt[j] = selectedRoadInt[j + 1];
                                selectedRoadInt[j + 1] = temp;

                                steps++;
                            }
                        }
                    }
                }
    
                selectedRoad = Array.ConvertAll(selectedRoadInt, element => element.ToString()); // Convert the int array back to a string array
    
                return selectedRoad;
        }

        // ==========================
        // ===== Insertion Sort =====
        // ==========================
        //
        // Description:
        //     Insertion sort is an in-place algorithm that iterates through the array
        //     and inserts each element into its correct position.
        // 
        // Time Complexity:
        //     Best Case: O(n)
        //     Average Case: O(n^2)
        //     Worst Case: O(n^2)
        //
        // Space Complexity:
        //     O(1)
        //
        // Notes:
        //     Insertion sort is an in-place algorithm and is faster than bubble sort.
        //     Insertion sort is not efficient for large data sets.
        //
        // Source:
        //     https://en.wikipedia.org/wiki/Insertion_sort
        //
        // ==========================
        public String[] InsertionSort(bool ascending) {

            int[] selectedRoadInt = Array.ConvertAll(selectedRoad, int.Parse); // Convert the string array to an int array
            
            if (ascending) { // Sorts the road in ascending order
                // Perform an insertion sort on the array
                for (int i = 1; i < selectedRoadInt.Length; i++) {

                    int j = i;

                    while (j > 0 && selectedRoadInt[j - 1] > selectedRoadInt[j]) {

                        int temp = selectedRoadInt[j];

                        selectedRoadInt[j] = selectedRoadInt[j - 1];
                        selectedRoadInt[j - 1] = temp;

                        j--;

                        steps++;
                    }
                }
            } else { // Sorts the road in descending order
                // Perform an insertion sort on the array
                for (int i = 1; i < selectedRoadInt.Length; i++) {

                    int j = i;

                    while (j > 0 && selectedRoadInt[j - 1] < selectedRoadInt[j]) {

                        int temp = selectedRoadInt[j];

                        selectedRoadInt[j] = selectedRoadInt[j - 1];
                        selectedRoadInt[j - 1] = temp;

                        j--;

                        steps++;
                    }
                }
            }

            selectedRoad = Array.ConvertAll(selectedRoadInt, element => element.ToString()); // Convert the int array back to a string array

            return selectedRoad;
        }

        // ==============================
        // ===== Merge Sort Methods =====
        // ==============================
        //
        // Description:
        //     Merge sort is a divide and conquer algorithm that recursively breaks down the array into smaller and smaller sub-arrays until the sub-arrays are of size 1.
        //     The sub-arrays are then merged back together in sorted order.
        //
        // Time Complexity:
        //     Best Case: O(n log n)
        //     Average Case: O(n log n)
        //     Worst Case: O(n log n)
        //
        // Space Complexity:
        //     O(n)
        //
        // Notes:
        //     Merge sort is recursive and is not an in-place algorithm like bubble sort and insertion sort.
        //     This takes up more space but is faster than bubble sort and insertion sort.
        //     Merge sort is efficient for large data sets.
        //
        // Source:
        //     https://en.wikipedia.org/wiki/Merge_sort
        //
        // ==============================

        public String[] MergeSort(bool ascending) {

            int[] selectedRoadInt = Array.ConvertAll(selectedRoad, int.Parse); // Convert the string array to an int array

            if (ascending) { // Sorts the road in ascending order
                // Perform a merge sort on the array
                selectedRoadInt = MergeSortAscending(selectedRoadInt, 0, selectedRoadInt.Length - 1);
            } else { // Sorts the road in descending order
                // Perform a merge sort on the array
                selectedRoadInt = MergeSortDescending(selectedRoadInt, 0, selectedRoadInt.Length - 1);
            }

            selectedRoad = Array.ConvertAll(selectedRoadInt, element => element.ToString()); // Convert the int array back to a string array

            return selectedRoad;
        }

        // Split the array into two sub-arrays and recursively call MergeSortAscending on each sub-array until the sub-arrays are of size 1
        int[] MergeSortAscending(int[] array, int left, int right) {

            if (left < right) {

                int middle = (left + right) / 2;

                MergeSortAscending(array, left, middle);
                MergeSortAscending(array, middle + 1, right);

                steps++;

                return MergeAscending(array, left, middle, right);
            }
            steps++;
            return array;
        }

        // Merge two sub-arrays back together in ascending order
        int[] MergeAscending(int[] array, int left, int middle, int right) {

            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            for (int i = 0; i < leftArray.Length; i++) {

                leftArray[i] = array[left + i];
            }

            for (int i = 0; i < rightArray.Length; i++) {

                rightArray[i] = array[middle + i + 1];
            }

            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = left; i < right + 1; i++) {

                if (leftIndex < leftArray.Length && rightIndex < rightArray.Length) {

                    if (leftArray[leftIndex] < rightArray[rightIndex]) {

                        array[i] = leftArray[leftIndex];
                        leftIndex++;

                    } else {

                        array[i] = rightArray[rightIndex];
                        rightIndex++;

                    }
                } else if (leftIndex < leftArray.Length) {

                    array[i] = leftArray[leftIndex];
                    leftIndex++;

                } else if (rightIndex < rightArray.Length) {

                    array[i] = rightArray[rightIndex];
                    rightIndex++;
                    
                }
            }
            steps++;
            return array;
        }

        // Split the array into two sub-arrays and recursively call MergeSortDescending on each sub-array until the sub-arrays are of size 1
        int[] MergeSortDescending(int[] array, int left, int right) {

            if (left < right) {

                int middle = (left + right) / 2;

                MergeSortDescending(array, left, middle);
                MergeSortDescending(array, middle + 1, right);

                steps++;

                return MergeDescending(array, left, middle, right);
            }
            steps++;
            return array;
        }

        // Merge two sub-arrays back together in descending order
        int[] MergeDescending(int[] array, int left, int middle, int right) {

            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            for (int i = 0; i < leftArray.Length; i++) {

                leftArray[i] = array[left + i];
            }

            for (int i = 0; i < rightArray.Length; i++) {

                rightArray[i] = array[middle + i + 1];
            }

            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = left; i < right + 1; i++) {

                if (leftIndex < leftArray.Length && rightIndex < rightArray.Length) { // If both sub-arrays still have elements

                    if (leftArray[leftIndex] > rightArray[rightIndex]) { 

                        array[i] = leftArray[leftIndex];
                        leftIndex++;

                    } else {

                        array[i] = rightArray[rightIndex];
                        rightIndex++;
                    }

                } else if (leftIndex < leftArray.Length) { // If only the left sub-array still has elements

                    array[i] = leftArray[leftIndex];
                    leftIndex++;

                } else if (rightIndex < rightArray.Length) { // If only the right sub-array still has elements

                    array[i] = rightArray[rightIndex];
                    rightIndex++;

                }
            }
            steps++;
            return array;
        }

        // ==============================
        // ===== Quick Sort Methods =====
        // ==============================
        //
        // Description:
        // Quick sort is a divide and conquer algorithm that recursively breaks down the array into smaller and smaller sub-arrays until the sub-arrays are of size 1.
        // The sub-arrays are then merged back together in sorted order.
        // This algorithm uses a pivot element to partition the array into two sub-arrays.
        // The pivot element is chosen to be the last element in the array.
        // The array is then partitioned into two sub-arrays, one containing elements less than the pivot and one containing elements greater than the pivot.
        // The pivot element is then placed in the middle of the two sub-arrays.
        // The sub-arrays are then recursively sorted.
        //
        // Time Complexity:
        // Best Case: O(n log n)
        // Average Case: O(n log n)
        // Worst Case: O(n^2)
        //
        // Space Complexity:
        // O(n)
        //
        // Notes:
        // Quick sort is recursive and is not an in-place algorithm like bubble sort and insertion sort.
        // This takes up more space but is faster than bubble sort and insertion sort.
        // Quick sort is efficient for large data sets.
        //
        // Source:
        // https://en.wikipedia.org/wiki/Quicksort
        //
        // ==============================
        public String[] QuickSort(bool ascending) {

            int[] selectedRoadInt = Array.ConvertAll(selectedRoad, int.Parse); // Convert the string array to an int array

            if (ascending) { // Sorts the road in ascending order
                // Perform a quick sort on the array
                selectedRoadInt = QuickSortAscending(selectedRoadInt, 0, selectedRoadInt.Length - 1);
            } else { // Sorts the road in descending order
                // Perform a quick sort on the array
                selectedRoadInt = QuickSortDescending(selectedRoadInt, 0, selectedRoadInt.Length - 1);
            }

            selectedRoad = Array.ConvertAll(selectedRoadInt, element => element.ToString()); // Convert the int array back to a string array

            return selectedRoad;
        }

        // Recursively call QuickSortAscending on the sub-arrays until the sub-arrays are of size 1
        int[] QuickSortAscending(int[] array, int left, int right) {

            if (left < right) {

                int pivot = PartitionAscending(array, left, right);

                QuickSortAscending(array, left, pivot - 1);
                QuickSortAscending(array, pivot + 1, right);

                steps++;
            }
            steps++;
            return array;
        }

        // Recursively call QuickSortDescending on the sub-arrays until the sub-arrays are of size 1
        int[] QuickSortDescending(int[] array, int left, int right) {

            if (left < right) {

                int pivot = PartitionDescending(array, left, right);

                QuickSortDescending(array, left, pivot - 1);
                QuickSortDescending(array, pivot + 1, right);

                steps++;
            }
            steps++;
            return array;
        }

        // Partition the array into two sub-arrays, one containing elements less than the pivot and one containing elements greater than the pivot
        int PartitionAscending(int[] array, int left, int right) {

            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++) {

                if (array[j] <= pivot) {

                    i++;

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp2 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp2;

            steps++;
            return i + 1;
        }

        // Partition the array into two sub-arrays, one containing elements greater than the pivot and one containing elements less than the pivot
        int PartitionDescending(int[] array, int left, int right) {

            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++) {

                if (array[j] >= pivot) {

                    i++;

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp2 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp2;

            steps++;
            return i + 1;
        }
    }
}