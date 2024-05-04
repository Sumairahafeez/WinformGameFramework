using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Interface
{
    public interface IMovement
    {
        Point Move(Point Location);
    }
}
