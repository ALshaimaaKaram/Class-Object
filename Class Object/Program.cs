using System;

namespace Class_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3DPoint
            _3DPoint p1 = new _3DPoint{X = 2, Y = 5, Z = 3};
            _3DPoint p2 = new _3DPoint(2) { Y = 5 };

            if (p1.Equals(p2))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

            Console.WriteLine("**********************************");

            if (p1 == p2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

            Console.WriteLine("**********************************");
            Console.WriteLine(p1);

            Console.WriteLine("**********************************");
            _3DPoint[] p = new _3DPoint[2];
            p[0] = p1;
            p[1] = p2;
            _3DPoint.Display(p);

            #endregion

            #region Person Class
            Console.WriteLine("**********************************");

            Address ad = new Address("Sohag", "aaa", 122555);
            Person[] r = new Person[2];

            r[0] = new Emploee(12, 2000,"Alshaimaa",25, ad);
            r[1] = new Trainee(13, 252, "Asmaa", 25, ad);


            Console.WriteLine(r[0]);
            Console.WriteLine("**********************************");

            Console.WriteLine(r[1]);
            Console.WriteLine("**********************************");

            Person ep = r[0].Clone();
            Console.WriteLine(ep);
            Console.WriteLine("**********************************");

            Person et = r[1].Clone();
            Console.WriteLine(et);

            #endregion

        }
    }
}
