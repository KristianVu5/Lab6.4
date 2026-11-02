using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._4
{
    internal class Box : Idimensions
    {
        private float lengthInInches;
        private float widthInInches;

        public Box(float lengthInInches, float widthInInches)
        {
            this.lengthInInches = lengthInInches;
            this.widthInInches = widthInInches;
        }

        public float Length()
        {
            return lengthInInches;
        }

        public float Width()
        {
            return widthInInches;
        }

    }
}
