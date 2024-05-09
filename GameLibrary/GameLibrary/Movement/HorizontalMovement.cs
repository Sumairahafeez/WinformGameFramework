using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Enum;

namespace GameLibrary.Movement
{
    public class HorizontalMovement : IMovement
    {
        //set attributes
        public int Speed;
        public Point Boundary;
        Direction direction;
        System.Drawing.Point ContainerCoordinates;
        // Constructor for HorizontalMovement
        public HorizontalMovement(int speed, Point boundary, Direction direction, Point containerCoordinates)
        {
            Speed = speed;
            Boundary = boundary;
            this.direction = direction;
            ContainerCoordinates = containerCoordinates;
        }

        // Implementation of the Move method from IMovement interface
        Point IMovement.Move(Point Location)
        {
            // Move right if the direction is Right
            if (direction == Direction.Right)
                Location.X += Speed;
            // Move left if the direction is Left
            else if (direction == Direction.Left)
                Location.X -= Speed;

            // If the object goes beyond the left boundary, reset its position to the right boundary
            if (Location.X - 30 <= 0)
                Location.X = ContainerCoordinates.X;
            // If the object goes beyond the right boundary, reset its position to the left boundary
            else if (Location.X - 30 >= ContainerCoordinates.X)
                Location.X = 0;

            // Return the updated location
            return Location;
        }
    }

}
