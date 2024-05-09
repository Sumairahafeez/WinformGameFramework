﻿using GameLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Movement
{
    public class VerticalMovement : IMovement
    {   //attributes for vertical movement
        public int Speed;
        public Point Boundary;
        Direction direction;
        Point FormWidth;
        public VerticalMovement(int speed, System.Drawing.Point Boundary, Direction Direction, Point FormWIDTH)
        {
            this.Speed = speed;
            this.Boundary = Boundary;
            this.direction = Direction;
            this.FormWidth = FormWIDTH;
        }
        //implementation for vertical motion
        Point IMovement.Move(Point Location)
        {
            if (direction == Direction.Up)
                Location.Y -= Speed;
            if (Location.Y >= FormWidth.Y)
            {
                Location.Y = 0;
            }
            else if (direction == Direction.Down)
                Location.Y += Speed;
           
            return Location;
        }
    }
}
