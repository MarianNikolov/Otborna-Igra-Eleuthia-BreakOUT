﻿namespace OtbornaIgra.GameObjects
{
    using System;
    using OtbornaIgra.Interfaces;

    public class BallGameObject : GameObjects, IMovable, IGameObject
    {
        public Position Speed {get;set;}

        public BallGameObject(Position givePosition,Size giveSize,Position giveSpeed):base(givePosition,giveSize)
        {
            this.Speed = (giveSpeed);
        }
        public void Move(int width, int height)
        {
            this.Position = new Position(width, height);
        }

        public void MoveWithCurrentSpeed()
        {
            this.Position = new Position(this.Position.Left+this.Speed.Left, this.Position.Top + this.Speed.Top);
        }

      

     
    }
}
