using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CoordinatesClass c = new CoordinatesClass();
                CoordinatesClass.Coordinate coordinate = new CoordinatesClass.Coordinate();
                bool run = true;
                while (run == true)
                {

                    Console.WriteLine("WELCOME TO THE BACKEND OF THE 'SECRET PROJECT'");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("GIVE ME THE COORDINATE VALUE OF X");
                    coordinate.x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("GIVE ME THE COORDINATE VALUE OF Y ");
                    coordinate.y = Convert.ToInt32(Console.ReadLine());
                    c.AddCoord(coordinate);
                    Console.WriteLine("COORDINATE ADDED");
                    c.ListCoords();
                    Console.WriteLine("TYPE END TO STOP THE PROGRAM");
                    string end = Console.ReadLine();
                    end = end.ToUpper();
                    if(end == "END")
                    {
                        run = false;
                    }
                    else
                    {

                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
