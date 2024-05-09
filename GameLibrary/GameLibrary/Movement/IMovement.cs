using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Movement
{   //implementation of movement 
    public interface IMovement
    {
        Point Move(Point Location);
    }
}
