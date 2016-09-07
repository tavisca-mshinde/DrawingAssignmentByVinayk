using System;
using Entity;

namespace Services
{
    public class LineService:ILineService
    {
        public string[,] DrawingLine(Line line, string[,] canvasStarage,Canvas canvas)
        {
            //string[,] lineStorage = new string[line.PointTwo.Y + 1, line.PointTwo.X + 1];
            //line.PointOne.X;line.PointOne.Y;line.PointTwo.X;line.PointTwo.Y
            //for (int i = 0; i < canvasStarage.GetLength(0); i++)
            //{
            //    for (int j = 0; j < canvasStarage.GetLength(1); j++)
            //    {
            //        Console.Write(canvasStarage[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            int width = canvasStarage.GetLength(0); // width
            int height = canvasStarage.GetLength(1); // height
                                                     //int indicesX = 0,indicesY=0;

            //for (int x = 0; x < width; ++x)
            //{
            //    for (int y = 0; y < height; ++y)
            //    {
            //        if (canvasStarage[x, y].Equals("*"))
            //        {
            //            indicesX = x;
            //            indicesY = y;
            //            break;
            //        }

            //    }
            //}


            
            for (int i = canvas.PointOne.Y + 1; i <= line.PointTwo.Y; i++)
            {
                for (int j = canvas.PointOne.X + 1; j <= line.PointTwo.X; j++)
                {
                    if (i < line.PointOne.Y)
                    {
                        if (canvasStarage[i, j] == ".")
                            continue;
                        else
                        canvasStarage[i, j] = " ";//Console.Write(" ");
                    }
                    else if (j < line.PointOne.X)
                    {
                        if (canvasStarage[i, j] == ".")
                            continue;
                        else
                        canvasStarage[i, j] = " ";//Console.Write(" ");
                    }
                    else
                    {
                        if (i == j)
                        {
                            canvasStarage[i, j] = "."; //Console.Write("*");
                        }
                        else
                        {
                            if (canvasStarage[i, j] == ".")
                                continue;
                            else
                                canvasStarage[i, j] = " ";//Console.Write(" ");

                        }
                    }
                }
                //Console.WriteLine();
            }

            //for (int i = canvas.PointOne.X+1; i <= line.PointTwo.X; i++)
            //{
            //    for (int j = canvas.PointOne.Y+1; j <= line.PointTwo.Y; j++)
            //    {
            //        if (j < line.PointOne.Y)
            //            canvasStarage[i, j] = " ";//Console.Write(" ");
            //        else if (i < line.PointOne.X)
            //            canvasStarage[i, j] = " ";//Console.Write(" ");
            //        else
            //        {
            //            if (i == j)
            //            {
            //                canvasStarage[i, j] = "*";//Console.Write("*");
            //            }
            //            else
            //                canvasStarage[i, j] = " ";//Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            return canvasStarage;
            //throw new NotImplementedException();
        }
    }
}