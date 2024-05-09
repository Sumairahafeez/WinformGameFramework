using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{   
    //A class to implement factory pattern by securing a count for player and other game objects
    public class FactoryPattern
    {   //set attributes
        private static int MaxPlayers;
        private static int MaxEnemies;
        private static int MaxBullets;
        private static int MaxObstacles;
        //Getter and setter for Attributes
        public static int GetMaxPlayers()
        {
            return MaxPlayers;
        }
        public static int GetMaxEnemies()
        {
            return MaxEnemies;
        }
        public static int GetMaxBullets()
        {
            return MaxBullets;
        }
        public static int GetMaxObstacles()
        {
            return MaxObstacles;
        }
        public static void SetMaxPlayers(int maxPlayers)
        {
            MaxPlayers = maxPlayers;
        }
        public static void SetMaxEnemy(int maxEnemy)
        {
            MaxEnemies = maxEnemy;
        }
        public static void SetMaxBullets(int maxBullets)
        {
            MaxBullets = maxBullets;
        }
        public static void SetMaxObstacles(int maxObstacles)
        {
            MaxObstacles = maxObstacles;
        }
    }
}
