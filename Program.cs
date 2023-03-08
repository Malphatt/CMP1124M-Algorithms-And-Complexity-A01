namespace CMP1124M_OOP {

    class Program {

        static void Main(string[] args) {
            // Create a new instance of the Roads class
            Roads roads = new Roads();

            // Sort the roads in ascending order
            roads.SortAscending("Road_1_256");
            roads.SortAscending("Road_2_256");
            roads.SortAscending("Road_3_256");

            //Display every 10th element of the roads
            for (int i = 0; i < roads._Road_1_256.Length; i += 10) {
                Console.WriteLine(roads._Road_1_256[i]);
            }
            for (int i = 0; i < roads._Road_2_256.Length; i += 10) {
                Console.WriteLine(roads._Road_2_256[i]);
            }
            for (int i = 0; i < roads._Road_3_256.Length; i += 10) {
                Console.WriteLine(roads._Road_3_256[i]);
            }

            // Sort the roads in descending order
            roads.SortDescending("Road_1_256");
            roads.SortDescending("Road_2_256");
            roads.SortDescending("Road_3_256");

            //Display every 10th element of the roads
            for (int i = 0; i < roads._Road_1_256.Length; i += 10) {
                Console.WriteLine(roads._Road_1_256[i]);
            }
            for (int i = 0; i < roads._Road_2_256.Length; i += 10) {
                Console.WriteLine(roads._Road_2_256[i]);
            }
            for (int i = 0; i < roads._Road_3_256.Length; i += 10) {
                Console.WriteLine(roads._Road_3_256[i]);
            }
        }
    }
}