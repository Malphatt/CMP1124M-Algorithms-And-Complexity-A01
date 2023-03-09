namespace CMP1124M_OOP {

    class Program {

        static void Main(string[] args) {
            // Create a new instance of the Roads class
            Roads roads = new Roads();

            // Display the 10th element of each road in ascending order
            foreach (String element in roads.Display10SortAscending("Road_1_256")) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10SortAscending("Road_2_256")) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10SortAscending("Road_3_256")) {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Display the 10th element of each road in descending order
            foreach (String element in roads.Display10SortDescending("Road_1_256")) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10SortDescending("Road_2_256")) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            foreach (String element in roads.Display10SortDescending("Road_3_256")) {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}