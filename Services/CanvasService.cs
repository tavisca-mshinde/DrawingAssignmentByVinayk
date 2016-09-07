using System;
using Entity;
using System.Drawing;

namespace Services
{
    public class CanvasService : ICanvasService
    {
        public string[,] DrawingCanvas(Canvas canvas)
        {
            //canvas.PointOne.X;canvas.PointOne.Y;canvas.PointTwo.X;canvas.PointTwo.Y;
            string[,] canvasStorage = new string[canvas.PointTwo.Y+1, canvas.PointTwo.X+1];
            for (int i = 0; i <= canvas.PointTwo.Y; i++)
            {

                for (int j = 0; j <= canvas.PointTwo.X; j++)
                {
                    if (i < canvas.PointOne.X)
                    {
                        canvasStorage[i, j] = " ";
                        //Console.Write(" ");
                    }
                    //Console.WriteLine();
                    else if (j < canvas.PointOne.Y)
                    {
                        canvasStorage[i, j] = " ";
                        //Console.Write(" ");
                    }

                    else
                    {
                        //if(i>=canvas.PointOne.X)
                        //{
                        //    if (i == canvas.PointOne.X)
                        //    {
                        //        canvasStorage[i, j] = "*";
                        //    }else if(i==canvas.PointTwo.X)
                        //    {
                        //        canvasStorage[i, j] = "*";
                        //    }else
                        //    {
                        //        canvasStorage[i, j] = " ";
                        //    }
                        //}
                        //else if(j>=canvas.PointOne.Y)
                        //{
                        //    if (j == canvas.PointOne.X)
                        //    {
                        //        canvasStorage[i, j] = "*";
                        //    }else if (j == canvas.PointTwo.X)
                        //    {
                        //        canvasStorage[i, j] = "*";
                        //    }
                        //    else
                        //    {
                        //        canvasStorage[i, j] = " ";
                        //    }
                        //}
                        if ((i == canvas.PointOne.X || i == canvas.PointTwo.X) && (j >= canvas.PointOne.Y && j <= canvas.PointTwo.Y))
                        {
                            canvasStorage[i, j] = "*";
                            //Console.Write("*");
                        }
                        else if ((j == canvas.PointOne.Y || j == canvas.PointTwo.Y) && (i >= canvas.PointOne.X && i <= canvas.PointTwo.X))
                        {
                            canvasStorage[i, j] = "*";
                            //Console.Write("*");
                        }
                        else
                        {
                            canvasStorage[i, j] = " ";
                            //Console.Write(" ");
                        }
                    }

                }
                //}
               // Console.WriteLine();
            }
            //int height = (canvas.YTwo - canvas.YOne);
            //int width = (canvas.XTwo - canvas.XOne);
            //for (int i = canvas.YOne; i <= canvas.YTwo; i++)
            //{
            //    for (int j = canvas.XOne; j <= canvas.XTwo; j++)
            //    {
            //        if (i == canvas.YOne || i == canvas.XTwo)
            //            Console.Write("*");
            //        else if (j == canvas.XOne || j == canvas.YTwo)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");

            //    }
            //    Console.WriteLine();
            //}
            //throw new NotImplementedException();
            return canvasStorage;
            //throw new NotImplementedException();
        }
    }
}