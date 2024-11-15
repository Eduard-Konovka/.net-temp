namespace OOP.Flat
{
    public class Flat 
    {
        public double Square {get; set;} = 50.0;
        public int Rooms {get; set;} = 2;
        public int Residents {get; set;} = 1;
        public string Address {get; set;} = "No address";

        public Flat() {}

        public Flat( double square, int rooms, int residents, string address ) 
        {
            Square = square;
            Rooms = rooms;
            Residents = residents;
            Address = address;
        }

        public Flat( double square, int rooms ) 
        {
            Square = square;
            Rooms = rooms;
        }

        public static void PrintFlat( string title, Flat obj ) 
        {
            string titleBorder = "═";
            string postTitle = title.Length % 2 == 0 ? " " : " ═";
            string squarePostSpaces = "";
            string roomsPostSpaces = "";
            string residentsPostSpaces = "";
            string addressPostSpaces = "";

            for (int i = 0; i < (26 - title.Length) / 2; i++)
            {
                titleBorder = titleBorder + "═";
            }

            for (int i = 0; i < 16 - obj.Square.ToString().Length; i++)
            {
                squarePostSpaces = squarePostSpaces + " ";
            }

            for (int i = 0; i < 17 - obj.Rooms.ToString().Length; i++)
            {
                roomsPostSpaces = roomsPostSpaces + " ";
            }

            for (int i = 0; i < 13 - obj.Residents.ToString().Length; i++)
            {
                residentsPostSpaces = residentsPostSpaces + " ";
            }

            for (int i = 0; i < 15 - obj.Address.Length; i++)
            {
                addressPostSpaces = addressPostSpaces + " ";
            }

            Console.WriteLine("╔" + titleBorder + " " + $"{title}" + postTitle + titleBorder +"╗");
            Console.WriteLine("║ Apartment parameters:        ║");
            Console.WriteLine($"║    square - {obj.Square};" + squarePostSpaces + "║");
            Console.WriteLine($"║    rooms - {obj.Rooms};" + roomsPostSpaces + "║");
            Console.WriteLine($"║    residents - {obj.Residents};" + residentsPostSpaces + "║");
            Console.WriteLine($"║    address - {obj.Address}." + addressPostSpaces + "║");
            Console.WriteLine("╚══════════════════════════════╝");
        }
    }
}
