using GameLibrary.GameObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary.Enum;
using GameLibrary.Movement;

namespace GameLibrary.Firing
{
    public class Player : IPlayer
    {
        Image Bullet;
        int StartWidth;
        int StartHeight;
        Point FormWidth;
        Game game;
        public Player(Image Bullet, int StartWidth, int StartHeight, Point FormWidth, Form form)
        {
            this.Bullet = Bullet;
            this.StartWidth = StartWidth;
            this.StartHeight = StartHeight;
            this.FormWidth = FormWidth;
            game = Game.GetValidInstance(form);
        }
        public void Fire(Image img)
        {
            int left = 0, top = 0;
            foreach (GameObject gameobject in Game.GetAllObjects())
            {
                if (gameobject.GetObjectType() == ObjectType.Player)
                {
                    left = gameobject.GetPictureBox().Left + gameobject.GetPictureBox().Width;
                    top = (gameobject.GetPictureBox().Top) + (gameobject.GetPictureBox().Height / 2);
                    break;
                }
            }
            game.AddGameObject(img, left, top, new HorizontalMovement(20, new Point(left, top), Direction.Right, new Point(game.GetForm().Width, game.GetForm().Height)), ObjectType.Bullet, true);

        }
    }
}
