using System;
using System.IO;

namespace minkowskiDiagram
{
    class MainClass
    {
        public const int N = 10;
        public static void Main(string[] args)
        {
            int i;
            double x, t, t1;

            string[] minkowski = new string[N+2];

            minkowski[0] = String.Format("light-sec. distance,sec. time");

            for (i = 0; i <= N; i++){
                x = (double)i / (double)N;
                t = x;
                t1 = x * 1.11;

                minkowski[i+1] = String.Format("{0:N},{1:N},{2:N}",x,t,t1);
            }
            File.WriteAllLines("minkowski.csv",minkowski);

            Console.WriteLine("have written file");
        }
    }
}
