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
            double x, t;

            string[] minkowski = new string[N+1];
            for (i = 0; i <= N; i++){
                x = (double)i / (double)N;
                t = x;
                
                minkowski[i] = String.Format("{0:N},{1:N}",x,t);
            }
            File.WriteAllLines("minkowski.csv",minkowski);

            Console.WriteLine("have written file");
        }
    }
}
