using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class TilingDemo
    {
        static void Main(string[] args)
        {

            Write("Enter the length of the room >> ");
            int x = Convert.ToInt32(ReadLine());
            Write("Enter the height of the room >> ");
            int y = Convert.ToInt32(ReadLine());
            Room inputfeet = new Room(x,y);


            WriteLine("The square feet of your room is {0} and you are going to need {1} boxes.",inputfeet.getFloorArea(), inputfeet.getBoxes());

            Console.Write("Click enter to escape...");
            Console.ReadLine();



        }
    }
}
