using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal class Point3D : IComparable, ICloneable

    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            Num1 = x;
            Num2 = y;
            Num3 = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: {Num1} , {Num2} , {Num3}";
        }

        public object Clone()
        {
            return new Point3D(Num1, Num2, Num3);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D other)
                return Num1 == other.Num1 && Num2 == other.Num2 && Num3 == other.Num3;
            return false;
        }
        public override int GetHashCode()
        {
            return (Num1, Num2, Num3).GetHashCode();
        }

        public int CompareTo(object? obj)
        {
            if (obj is Point3D other)
            {
                if (Num1 != other.Num1)
                    return Num1.CompareTo(other.Num1);
                if (Num2 != other.Num2)
                    return Num2.CompareTo(other.Num2);
                else return Num3.CompareTo(other.Num3);
            }
            throw new ArgumentException("Invalid!");
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return left?.Equals(right) ?? right is null;
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !(left == right);
        }


    }
}
