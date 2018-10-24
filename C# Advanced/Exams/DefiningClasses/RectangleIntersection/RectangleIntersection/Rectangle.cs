using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    public class Rectangle
    {
        //Fields
        private string id;
        private double width;
        private double height;
        private double leftCornerX;
        private double leftCornerY;

        //Cosntrutors
        public Rectangle(string id, double width, double height, double leftCornerX, double leftCornerY)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.leftCornerX = leftCornerX;
            this.leftCornerY = leftCornerY;
        }

        //Properties
        public double LeftCornerY
        {
            get { return leftCornerY; }
            set { leftCornerY = value; }
        }


        public double LeftCornerX
        {
            get { return leftCornerX; }
            set { leftCornerX = value; }
        }


        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        //Methods
        public bool RectIntersect(Rectangle R2)
        {
            if ((LeftCornerX > (R2.leftCornerX + R2.width)) || ((LeftCornerX + Width) < R2.LeftCornerX) || (leftCornerY > (R2.leftCornerY + R2.Height)) ||
                 ((leftCornerY + Height) < R2.LeftCornerY))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}