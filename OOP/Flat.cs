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
            Console.WriteLine(); 
            Console.WriteLine($"====={title}=====");
            Console.WriteLine("Apartment parameters:");
            Console.WriteLine($"   square - {obj.Square};");
            Console.WriteLine($"   rooms - {obj.Rooms};");
            Console.WriteLine($"   residents - {obj.Residents};");
            Console.WriteLine($"   address - {obj.Address}.");
            Console.WriteLine("===========================");
        }
    }
}
