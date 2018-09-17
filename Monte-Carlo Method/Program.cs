using System;

namespace Monte_Carlo_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type in a number: ");
                int arrayLength = Convert.ToInt32(Console.ReadLine());
                Coordinate[] OfCordinate = new Coordinate[arrayLength];
                Random random = new Random();
                int counter = 0;
                for (int i = 0; i < arrayLength; i++)
                {
                    OfCordinate[i] = new Coordinate(random);

                    if (OfCordinate[i].Hypotenuse() <= 1)
                    {
                        counter++;
                    }
                }
                double avg = (counter / (double)OfCordinate.Length) * 4;
                Console.WriteLine($"Total # of points overlapping the circle = {counter}");
                Console.WriteLine($"generated pi = {avg}, " + $"pi = {Math.PI}, " + $"what the difference is = {Math.Abs(Math.PI - avg)}");
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }
    }
}
