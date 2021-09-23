using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix22
    {
        public float[,] elements = new float[2, 2];
        

        public Matrix22 Add(Matrix22 other)
        {
            Matrix22 result = new Matrix22();
            result.elements[0, 0] = this.elements[0, 0] + other.elements[0, 0];
            result.elements[0, 1] = this.elements[0, 1] + other.elements[0, 1];
            result.elements[1, 0] = this.elements[1, 0] + other.elements[1, 0];
            result.elements[1, 1] = this.elements[1, 1] + other.elements[1, 1];
            return result;
        }

        public static Matrix22 CreateRotation(float radians)
        {
            Matrix22 result = new Matrix22();

            result.elements[0, 0] = ((float)Math.Cos(radians));
            result.elements[0, 1] = ((float)Math.Sin(radians));
            result.elements[1, 0] = ((float)-Math.Sin(radians));
            result.elements[1, 1] = ((float)Math.Cos(radians));
            return result;
        }

        public Matrix22 Muliply(Matrix22 other)
        {
            Matrix22 result = new Matrix22();
            result.elements[0, 0] = this.elements[0, 0] * other.elements[0, 0] + this.elements[0, 1] * other.elements[1, 0];
            result.elements[0, 1] = this.elements[0, 0] * other.elements[1, 0] + this.elements[0, 1] * other.elements[1, 1];
            result.elements[1, 0] = this.elements[1, 0] * other.elements[0, 0] + this.elements[1, 1] * other.elements[1, 0];
            result.elements[1, 1] = this.elements[1, 0] * other.elements[0, 1] + this.elements[1, 1] * other.elements[1, 1];
            return result;
        }
    }
}
