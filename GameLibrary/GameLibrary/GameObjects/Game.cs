using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary.Enum;
using GameLibrary.Movement;

namespace GameLibrary.GameObjects
{
    public class Game
    {   //Declare all the list objects of game;
        private static List<GameObject> gameObjectList;
        private static Form container;
        private static Game Instance;
        private static List<GameObject> EnemyObjects;
        private static List<GameObject> PlayerObjects;
        private static List<GameObject> Bullets;
        //Implementation of singleton principle
        private Game(Form container)
        {
            gameObjectList = new List<GameObject>();
            EnemyObjects = new List<GameObject>();
            PlayerObjects = new List<GameObject>();
            Bullets = new List<GameObject>();
            SetContainer(container);
        }
        //function to return a valid instance
        public static Game GetValidInstance(Form Container)
        {
            if (Instance == null)
            {
                Instance = new Game(Container);
            }
            return Instance;
        }
        //it adds the game objects in all specific lists
        public void AddGameObject(Image img, int left, int top, IMovement controller, ObjectType Type, bool isVisible)
        {
            GameObject gameObject = GameObject.GetObjectInstance(img, left, top, controller, Type, isVisible);
            if (gameObject != null)
            {
                if (Type == ObjectType.Enemy)
                {
                    EnemyObjects.Add(gameObject);
                }
                else if (Type == ObjectType.Player)
                {
                    PlayerObjects.Add(gameObject);
                }
                else if (Type == ObjectType.Bullet)
                {
                    Bullets.Add(gameObject);
                }
                AddObject(gameObject);
                container.Controls.Add(gameObject.GetPictureBox());
            }

        }
        //It sets the container form
        public void SetContainer(Form form)
        {
            container = form;
        }
        public Form GetForm()
        {
            return container;
        }
        public void Update()
        {
            foreach (GameObject go in gameObjectList)
            {
                go.update(go.GetPosition());
                //CollissionDetector.PlayerVSEnemy(ObjectType.Player, ObjectType.Enemy);

            }
        }
        //function to update the object list
        public static void Update(GameObject go)
        {
            gameObjectList.Add(go);
        }
        //Getter setters for the lists
        public static List<GameObject> GetPlayers()
        {
            return PlayerObjects;
        }
        public static List<GameObject> GetEnemies()
        {
            return EnemyObjects;
        }
        public static List<GameObject> GetBullets()
        {
            return Bullets;
        }
        public static List<GameObject> GetAllObjects()
        {
            return gameObjectList;
        }
        public void AddObject(GameObject go)
        {
            gameObjectList.Add(go);
        }
        public static void RemoveObject(GameObject go)
        {
            gameObjectList.Remove(go);
            container.Controls.Remove(go.GetPictureBox());
        }
    }

}
