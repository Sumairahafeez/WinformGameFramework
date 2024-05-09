using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Enum
{   //enum for actions to be on on collision
    public enum Actions
    {
        None,
        PlayerDead,
        EnemyDead,
        PlayerHealthReduction,
        PlayerScoreIncrement
    }
}
