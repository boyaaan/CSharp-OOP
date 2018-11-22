using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        private int wight;
        private string type;

        public Cargo(int wight, string type)
        {
            this.Wight = wight;
            this.Type = type;
        }

        public int Wight
        {
            get { return this.wight; }
            set { this.wight = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
