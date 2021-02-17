using System;
using System.Collections.Generic;
using System.Text;

namespace road
{
    class Road
    {
        public string Type;
        public int Speed;
        public int Sails;
        public int Length;
        public string Name;

        public Road(string T, int s, int sa, int l, string n)
        {
            this.Type = T;
            this.Speed = s;
            this.Sails = sa;
            this.Length = l;
            this.Name = n;
        }
        public Road()
        {
            this.Type = "Highway";
            this.Speed = 140;
            this.Sails = 418;
            this.Length = 4;
            this.Name = "Hemus";

        }
        public override string ToString()
        {
            return "The type is: " + " " + this.Type + "the speed: " +" " + this.Speed + "the sails: " +" " + this.Sails + "the lenght: " + " " + this.Length + "the name of road is:" + this.Name;
        }
    }
    
}
