using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_tetris
{
    class util
    {
    
        public string nextBlock( Random rng)
        {
            string[] piece = { "L", "I", "O", "T", "S", "Z", "J" };
            return piece[rng.Next(8)];
        }
    }
}
