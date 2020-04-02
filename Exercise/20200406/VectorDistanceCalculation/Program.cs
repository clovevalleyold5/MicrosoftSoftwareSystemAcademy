using System;
using System.Collections.Generic;

namespace VectorDistanceCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Points2D[] points2D = new Points2D[10];
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(1, 10);
                int y = random.Next(1, 10);
                points2D[i] = new Points2D(x, y);
            }
            for (int i = 0; i < 10; i++)
            {
                double closestDistance = Math.Sqrt(200);
                int closestPoint = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (j != i)
                    {
                        double distance = points2D[i].Distance2D(points2D[j]);
                        if (distance < closestDistance)
                        {
                            closestPoint = j;
                            closestDistance = distance;
                        }
                    }
                }
                Console.WriteLine("closest point to point " + i + " " + points2D[i].Location2D() + " is point " + closestPoint + " " + points2D[closestPoint].Location2D() + ", the distance is " + closestDistance);
            }
            Console.WriteLine();
            Points3D[] points3D = new Points3D[10];
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(1, 10);
                int y = random.Next(1, 10);
                int z = random.Next(1, 10);
                points3D[i] = new Points3D(x, y, z);
            }
            for (int i = 0; i < 10; i++)
            {
                double closestDistance = Math.Sqrt(300);
                int closestPoint = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (j != i)
                    {
                        double distance = points3D[i].Distance3D(points3D[j]);
                        if (distance < closestDistance)
                        {
                            closestPoint = j;
                            closestDistance = distance;
                        }
                    }
                }
                Console.WriteLine("closest point to point " + i + " " + points3D[i].Location3D() + " is point " + closestPoint + " " + points3D[closestPoint].Location3D() + ", the distance is " + closestDistance);
            }
        }
        class Points2D
        {
            private int x, y;
            public Points2D(int xx, int yy)
            {
                x = xx;
                y = yy;
            }
            public string Location2D()
            {
                return "(" + x.ToString() + "," + y.ToString() + ")";
            }
            public double Distance2D(Points2D p)
            {
                double distance = Math.Sqrt((Math.Pow((x - p.x), 2) + Math.Pow((y - p.y), 2)));
                return distance;
            }
        }
        class Points3D
        {
            private int x, y, z;
            public Points3D(int xxx, int yyy, int zzz)
            {
                x = xxx;
                y = yyy;
                z = zzz;

            }
            public string Location3D()
            {
                return "(" + x.ToString() + "," + y.ToString() + "," + z.ToString() + ")";
            }
            public double Distance3D(Points3D p)
            {
                double distance = Math.Sqrt((Math.Pow((x - p.x), 2) + Math.Pow((y - p.y), 2) + Math.Pow((z - p.z), 2)));
                return distance;
            }
        }
    }
}
