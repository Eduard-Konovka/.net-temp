using System;
using Functions;
using OOP.Flat;

public class Program 
{
    public static void Main() 
    {
        FunctionsMain.Task1();

        Flat fullFlat = new Flat( 75.0, 3, 2, "Izmayil" );
        Flat defaultflat = new Flat();
        Flat partFlat = new Flat(95.5, 4 );
        
        Flat.PrintFlat( "Full params", fullFlat);
        Flat.PrintFlat( "Default params", defaultflat);
        Flat.PrintFlat( "Part params", partFlat);
    }
}