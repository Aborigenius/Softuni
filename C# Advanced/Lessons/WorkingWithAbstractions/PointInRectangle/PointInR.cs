using System;
using System.Linq;

namespace PointInRectangle
{
    class PointInR
    {
        static void Main(string[] args)
        {
            int []initialCoordinates = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Rectangle rectangleFromConst = new Rectangle(new Point(3, 6), new Point(8, 4));
            Rectangle rectangle = new Rectangle()
            {
                UpperLeftCorner = new Point(initialCoordinates[0], initialCoordinates[1]),
                LowerRightCorner = new Point(initialCoordinates[2], initialCoordinates[3])
            };
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int[] tokens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                Point point = new Point(tokens[0], tokens[1]);
                Point some = new Point(5, 4);

                Console.WriteLine(rectangle.Contains(some));
            }

            Rectangle SuperNew = new Rectangle();
            SuperNew.LowerRightCorner = new Point(8, 4);
            SuperNew.UpperLeftCorner = new Point(3, 6);

            Console.WriteLine(rectangleFromConst.Contains(new Point(1,5)));
            Console.WriteLine(rectangleFromConst.Contains(new Point(5,4)));
        }
    }
}
