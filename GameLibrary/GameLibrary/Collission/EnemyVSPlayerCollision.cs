using GameLibrary.Enum;
using GameLibrary.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Collission
{
    public class EnemyVSPlayerCollision : ICollision
    {
        string ICollision.DetectCollision(Actions actions)
        {   //gets th elist of objects who are bound to cllide in thi sclass
            List<GameObject> Players = Game.GetPlayers();
            List<GameObject> Enemy = Game.GetEnemies();
            //traverses the objects in both loops 
            foreach (GameObject Player in Players)
            {
                foreach (GameObject EnemyPlayer in Enemy)
                {   //if the players collide it will perform the given action
                    if (Player.GetPictureBox().Bounds.IntersectsWith(EnemyPlayer.GetPictureBox().Bounds))
                    {
                        if (actions == Actions.PlayerHealthReduction)
                        {
                            Player.SetHealth(Player.GetHealth() - 10f);
                            return Player.GetHealth().ToString();
                        }
                        if (actions == Actions.PlayerScoreIncrement)
                        {
                            Player.SetScore(Player.GetScore() + 10);
                            return Player.GetScore().ToString();
                        }
                        if (actions == Actions.EnemyDead)
                        {
                            Enemy.Remove(Player);
                            EnemyPlayer.GetPictureBox().Visible = false;
                            return Actions.EnemyDead.ToString();
                        }
                        else if (actions == Actions.PlayerDead)
                        {
                            Players.Remove(Player);
                            Player.GetPictureBox().Visible = false;
                            return Actions.PlayerDead.ToString();
                        }

                    }
                }
            }
            return null;
        }
    }
}
