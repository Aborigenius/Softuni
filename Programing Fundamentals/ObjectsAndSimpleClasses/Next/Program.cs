using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime input = DateTime.ParseExact(
            //     Console.ReadLine(), "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture
            //     );
            //
            // Console.WriteLine(input.DayOfWeek);
            // Point firstPoint = Point.ParsePoint(Console.ReadLine());
            // Point secondPoint = Point.ParsePoint(Console.ReadLine());
            //
            // double distance = CalcDistance(firstPoint, secondPoint);
            //
            // Console.WriteLine($"{distance:f3}");

            int n =int.Parse(Console.ReadLine());
            List < Point > points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point currentPoint = Point.ParsePoint(Console.ReadLine());
                points.Add(currentPoint);
            }

            double minDistance = double.MaxValue;
            Point[] bestPoints = new Point[2];

            for (int previousP = 0; previousP < points.Count; previousP++)
            {
                for (int currentP = previousP +1; points.Count < previousP; currentP++)
                {
                    double distance = CalcDistance(points[previousP], points[currentP]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        bestPoints[0] = points[previousP];
                        bestPoints[1] = points[currentP];

                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"{bestPoints[0]}");
            Console.WriteLine($"{bestPoints[1]}");
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(sideA + sideB);

        }

        private static Point ReadPoint(string input)
        {
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();
            return new Point(inputData[0], inputData[1]);
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int xCoord, int yCoord)
            {
                X = xCoord;
                Y = yCoord;
            }

            public static Point ParsePoint(string input)
            {
                int[] inputData = input.Split(' ').Select(int.Parse).ToArray();
                return new Point(inputData[0], inputData[1]);

            }

            public override string ToString()
            {
                return String.Format($"({X}, {Y})");
            }
        }
    }
}
