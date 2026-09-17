using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWeek3
{
    internal class Dice
    {
        private byte face;
        public byte Face { get { return face; } }
        public override bool Equals(object? obj)
        { 
            if (obj is Dice otherDice)
            {
                return this.face == otherDice.face;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
