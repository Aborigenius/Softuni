using System;
using System.Collections.Generic;

namespace RectangleIntersection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputNM = Console.ReadLine().Split(" ");
            int rectanglesCount = int.Parse(inputNM[0]);
            int intersectionChecks = int.Parse(inputNM[1]);

            //  List<Rectangle> rectangles = new List<Rectangle>();
            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < rectanglesCount; i++)
            {
                string[] inputLines = Console.ReadLine().Split(" ");
                string id = inputLines[0];
                double width = double.Parse(inputLines[1]);
                double height = double.Parse(inputLines[2]);
                double leftX = double.Parse(inputLines[3]);
                double leftY = double.Parse(inputLines[4]);

                Rectangle rectangle = new Rectangle(id, width, height, leftX, leftY);
                rectangles.TryAdd(id, rectangle);
            }

            string idLine = null;
            for (int i = 0; i < intersectionChecks; i++)
            {
                idLine += Console.ReadLine() + " ";
            }
            string[] ids = idLine.Split(" ");

            for (int i = 0; i < ids.Length - 1; i += 2)
            {
                string name1 = ids[i];
                string name2 = ids[i + 1];

                Rectangle R1 = rectangles.GetValueOrDefault(name1);
                Rectangle R2 = rectangles.GetValueOrDefault(name2);

                Console.WriteLine(R1.RectIntersect(R2).ToString().ToLower());
            }

        }
    }
}
