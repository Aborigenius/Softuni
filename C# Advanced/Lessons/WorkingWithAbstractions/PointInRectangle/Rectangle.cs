namespace PointInRectangle
{
    public class Rectangle
    {
        public Point UpperLeftCorner { get; set; }
        public Point LowerRightCorner { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(Point upperLeft, Point lowerRight)
        {
            UpperLeftCorner = upperLeft;
            LowerRightCorner = lowerRight;
        }

        public bool Contains(Point point)
        {
            bool isInHorizontal = point.PointX >= UpperLeftCorner.PointX &&
                point.PointX <= LowerRightCorner.PointX;

            bool isInVertical = point.PointY <= UpperLeftCorner.PointY &&
                point.PointY >= LowerRightCorner.PointY;

            return isInHorizontal && isInVertical;
        } 
    }
}
