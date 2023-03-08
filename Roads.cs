namespace CMP1124M_OOP {

    class Roads {

        String[] Road_1_256;
        public String[] _Road_1_256 {
            get { return Road_1_256; }
            set { Road_1_256 = value; }
        }

        String[] Road_2_256;
        public String[] _Road_2_256 {
            get { return Road_2_256; }
        }

        String[] Road_3_256;
        public String[] _Road_3_256 {
            get { return Road_3_256; }
        }

        public Roads() {
            Road_1_256 = System.IO.File.ReadAllLines("Roads/Road_1_256.txt");
            Road_2_256 = System.IO.File.ReadAllLines("Roads/Road_2_256.txt");
            Road_3_256 = System.IO.File.ReadAllLines("Roads/Road_3_256.txt");
        }

        public void SortAscending(String road) {
            if (road == "Road_1_256") {
                Array.Sort(Road_1_256);
            } else if (road == "Road_2_256") {
                Array.Sort(Road_2_256);
            } else if (road == "Road_3_256") {
                Array.Sort(Road_3_256);
            } else {
                Console.WriteLine("Invalid road name");
            }
        }

        public void SortDescending(String road) {
            if (road == "Road_1_256") {
                Array.Sort(Road_1_256);
                Array.Reverse(Road_1_256);
            } else if (road == "Road_2_256") {
                Array.Sort(Road_2_256);
                Array.Reverse(Road_2_256);
            } else if (road == "Road_3_256") {
                Array.Sort(Road_3_256);
                Array.Reverse(Road_3_256);
            } else {
                Console.WriteLine("Invalid road name");
            }
        }

        
    }
}