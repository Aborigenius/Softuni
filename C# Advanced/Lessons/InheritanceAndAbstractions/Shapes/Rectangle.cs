using System;

namespace Shapes
{
    class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Height
        {
            get { return height; }
            private set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Height must me 4 or more!");
                }
                height = value;
            }
        }


        public int Width
        {
            get { return width; }
            private set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Width must me 4 or more!");
                }
                width = value;
            }
        }


        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine(new String('*', Width));

            for (int i = 0; i < Height - 2; i++)
            {
                Console.WriteLine($"*{new string(' ', Width - 2)}*");
            }

            Console.WriteLine(new String('*', Width));
        }
    }
}
