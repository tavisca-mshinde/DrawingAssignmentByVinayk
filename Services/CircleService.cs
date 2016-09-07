using System;
using Entity;

namespace Services
{
    public class CircleService : ICircleService
    {
        public string[,] DrawingCircle(Circle circle, string[,] canvasStaorage, Canvas canvas)
        {

            //circle.PointOne.X;circle.PointOne.Y;circle.Radius;
            int startX = circle.PointOne.X - circle.Radius;
            int startY = circle.PointOne.X - circle.Radius;

            for(int i = canvas.PointOne.Y; i < canvas.PointTwo.Y; i++)
            {
                for(int j = canvas.PointOne.X; j < canvas.PointTwo.X; j++)
                {
                    if ((Math.Sqrt(Math.Pow(Math.Abs(circle.PointOne.X - i), 2) + Math.Pow(Math.Abs(circle.PointOne.Y - j), 2))) == circle.Radius)
                    {
                        canvasStaorage[i,j] = ".";
                    }
                    else
                    {
                        if (canvasStaorage[i, j] == "."|| canvasStaorage[i, j] == "*")
                            continue;
                        else
                            canvasStaorage[i, j] = " ";
                    }
                }
            }
            //throw new NotImplementedException();
            return canvasStaorage;
        }
    }
}