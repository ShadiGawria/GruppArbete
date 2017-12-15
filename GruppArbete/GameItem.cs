using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppArbete
{
    public class GameItem
    {
        public int character;
        public int laser, door, wall,treasure;
       
        public GameItem()
        {
            character = 2;
            laser = 5;
            door = 4;
            wall = 1;
            treasure = 3;
        }
    }
}
