using System;

namespace Opgave1OOP
{
    public class Square
    {
        static void Main(string[] args)
        {   //this finds the perimeter of a square
            int Omkreds, perimeter; //here i make 2 integers called omkreds and perimeter
            Console.WriteLine("side: "); 
            Omkreds = Convert.ToInt32(Console.ReadLine()); //here i make it possible for a user to input a length
            perimeter = 2 * Omkreds * Omkreds; // heres the calculation to find the perimeter for a square
            Console.WriteLine("Perimeter of Square : " + perimeter); //the result
            //this finds the area of a square
            int Areal, a; //here i make 2 integers called Areal and a
            Console.WriteLine("side: ");
            Areal = Convert.ToInt32(Console.ReadLine()); //here i again make it possible for an user to input a length
            a = Areal * Areal; //here it calculates the areal of a square
            Console.WriteLine("the area of square: " + a); //the result

        }
    }
  
}
