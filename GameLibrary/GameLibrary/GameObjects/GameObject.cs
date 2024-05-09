using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary.Enum;
using GameLibrary.Movement;
using GameLibrary;

namespace GameLibrary.GameObjects
{
    public class GameObject
    {   //sets the attributes of a game object
        private PictureBox Pb;
        private IMovement controller;
        private System.Drawing.Point Position;
        private static GameObject ObjectInstance;
        private ObjectType Type;
        private int Score = 0;
        private float Health = 100;
        //singleton principle for th eimplementation of factory pattern
        private GameObject(Image img, int left, int top, IMovement controller, ObjectType Type, bool isVisible)
        {
            Position = new System.Drawing.Point(left, top);
            Pb = new PictureBox();
            Pb.Image = img;
            Pb.Location = Position;
            Pb.Size = new Size(img.Width, img.Height);

            Pb.Size = new Size(img.Width / 2, img.Height / 2);

            Pb.Size = new Size((img.Width / 2), (img.Height));
            Pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb.BackColor = Color.Transparent;
            Pb.Visible = isVisible;
            this.controller = controller;
            SetObjectTypes(Type);
        }
        //instance setter for implementation of factory pattern
        public static GameObject GetObjectInstance(Image img, int left, int top, IMovement controller, ObjectType Type, bool isVisble)
        {
            if ((FactoryPattern.GetMaxObstacles() <= 15) && (FactoryPattern.GetMaxPlayers() <= 5) && (FactoryPattern.GetMaxEnemies() <= 100))
            {
                ObjectInstance = new GameObject(img, left, top, controller, Type, isVisble);
                return ObjectInstance;
            }
            else
            {
                throw new Exception("More than capacity production");
            }
            

        }
        //getter setter for the private attributes
        public PictureBox GetPictureBox()
        {
            return Pb;
        }
        public void SetPictureBox(PictureBox Pb)
        {
            this.Pb = Pb;
        }
        public void SetMovement(IMovement movement)
        {
            this.controller = movement;
        }
        public IMovement GetMovement()
        {
            return this.controller;
        }
        public int GetScore()
        {
            return Score;
        }
        public void SetScore(int Score)
        {
            this.Score = Score;
        }
        public void SetHealth(float Health)
        {
            this.Health = Health;
        }
        public float GetHealth()
        {
            return Health;
        }
        //it sets the types of objects and increment them in th efactory
        public void SetObjectTypes(ObjectType Type)
        {
            if (Type == ObjectType.Player)
            {
                FactoryPattern.SetMaxPlayers(FactoryPattern.GetMaxPlayers() + 1);

            }
            else if (Type == ObjectType.Enemy)
            {
                FactoryPattern.SetMaxEnemy(FactoryPattern.GetMaxEnemies() + 1);
            }
            else if (Type == ObjectType.Bullet)
            {
                FactoryPattern.SetMaxBullets(FactoryPattern.GetMaxBullets() + 1);
            }
            this.Type = Type;
        }
        public ObjectType GetObjectType()
        {
            return Type;
        }
        public void SetPosition(System.Drawing.Point Position)
        {
            this.Position = Position;
        }
        public System.Drawing.Point GetPosition()
        {
            return Position;
        }
        //Updates the picture boc and sets it to new location
        public void update(System.Drawing.Point Location)
        {

            Position = controller.Move(Location);
                                         
            Pb.Location = Position;


        }
       
       
    }
}
