using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates
{
    class CoordinatesClass
    {
        //Coordinate class to store values of a coordinate
        public class Coordinate
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        //Declare the list of Coordinates
        List<Coordinate> CoordList = new List<Coordinate>();

        //Function to add a coordinate to the coordinate list
        public void AddCoord(Coordinate Coord)
        {
            CoordList.Add(new Coordinate { x = Coord.x, y = Coord.y });
        }

        //Function to list the coordinates stored in the list
        public void ListCoords()
        {
            foreach(var C in CoordList)
            {
                Console.WriteLine("({0}, {1})" ,C.x,C.y);
                Console.WriteLine();
            }
        }

    }
}
