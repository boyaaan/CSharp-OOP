using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engein
    {
        private int speed;
        private int power;

        public Engein(int speed , int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

    }
}
