using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class _3DPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint() : this(1, 2, 3)
        {

        }

        public _3DPoint(int X) : this(X, 2, 3)
        {
            this.X = X;
        }

        public _3DPoint(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override bool Equals(Object obj)
        {
            _3DPoint p = obj as _3DPoint;
            if (p == null)
                return false;
            return p.X == this.X && p.Y == this.Y && p.Z == this.Z;
        }
       
        public override string ToString()
        {
            return $"X = {X} ,Y = {Y}, Z = {Z}";
        }


        public static void Display(_3DPoint[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                //arr[i].ToString();
                Console.WriteLine(arr[i]);
                //Console.WriteLine($"X is {arr[i].X}, Y is {arr[i].Y}, Z is {arr[i].Z}");
            }
        }
    }
}
