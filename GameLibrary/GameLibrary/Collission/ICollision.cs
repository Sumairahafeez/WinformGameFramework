using GameLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Collission
{   //Interface for detecting collision and implementing it
    public interface ICollision
    {
        string DetectCollision(Actions action);
    }
}
