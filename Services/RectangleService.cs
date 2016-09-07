using System;
using Entity;

namespace Services
{
    public class RectangleService : IRectangleService
    {
        public string[,] DrawingRectangle(Rectangle rectangle,string[,] canvasStorage,Canvas canvas)
        {
            //int height = (int)(rectangle.PointTwo.Y - rectangle.PointOne.Y);
            //int width = (int)(rectangle.PointTwo.X - rectangle.PointOne.X);

            //string[,] rectangleStorage = new string[rectangle.PointTwo.Y + 1, rectangle.PointTwo.X + 1];
            //canvas.PointOne.X; canvas.PointOne.Y;

            for (int i = canvas.PointOne.Y+1 ; i <= rectangle.PointTwo.Y; i++)
            {

                for (int j = canvas.PointOne.Y+1; j <= rectangle.PointTwo.X; j++)
                {
                    if (i < rectangle.PointOne.X)
                    {
                        if (canvasStorage[i, j] == ".")
                            continue;
                        else
                            canvasStorage[i, j] = " ";
                        //Console.Write(" ");
                    }
                    //Console.WriteLine();
                    else if (j < rectangle.PointOne.Y)
                    {
                        if (canvasStorage[i, j] == ".")
                            continue;
                        else
                            canvasStorage[i, j] = " ";
                        //Console.Write(" ");
                    }

                    else
                    {
                        if (i == rectangle.PointOne.X || i == rectangle.PointTwo.X)
                        {
                            canvasStorage[i, j] = ".";
                            //Console.Write("*");
                        }
                        else if (j == rectangle.PointOne.Y || j == rectangle.PointTwo.Y)
                        {
                            canvasStorage[i, j] = ".";
                            //Console.Write("*");
                        }
                        else
                        {
                            if (canvasStorage[i, j] == ".")
                                continue;
                            else
                                canvasStorage[i, j] = " ";
                            //Console.Write(" ");
                        }
                    }

                }
                //}
                //Console.WriteLine();
            }



            //for (int i = canvas.PointOne.Y+1; i <= rectangle.PointTwo.Y; i++)
            //{
            //    for (int j = canvas.PointOne.X+1; j <= rectangle.PointTwo.X; j++)
            //    {
            //        if (i == rectangle.PointOne.Y || i == rectangle.PointTwo.X)
            //            canvasStorage[i, j] = "*";//Console.Write("*");
            //        else if (j == rectangle.PointOne.X || j == rectangle.PointTwo.Y)
            //            canvasStorage[i, j] = "*";//Console.Write("*");
            //        else
            //            canvasStorage[i, j] = "*";//Console.Write(" ");
            //        //if(i==rectangle.PointOneY )
            //        //Console.Write("*");
            //        //if (j == rectangle.PointOneY || j == rectangle.PointTwoY)
            //        //    Console.Write("*");
            //        //if(j==rectangle.PointOneX || j==rectangle.PointTwoY)
            //        //    Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            return canvasStorage;
            //throw new NotImplementedException();
        }
    }
}