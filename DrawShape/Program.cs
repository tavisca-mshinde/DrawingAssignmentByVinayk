using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Drawing;
using Factory;
using Services;
using Validate;

using log4net;
using log4net.Config;

namespace DrawShape
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            try
            {

                int x, y;

                Entity.Canvas canvas = new Entity.Canvas();//FactoryRectangleObject.GetRectagle();
                Console.WriteLine("Enter values for co-ordinates");
                Console.WriteLine("Enter X co-ordinate for point one");
                x = Validate.Validate.ValidateNumber(Console.ReadLine());
                Console.WriteLine("Enter Y co-ordinate for point one");
                y = Validate.Validate.ValidateNumber(Console.ReadLine());
                canvas.PointOne = new Point(x, y);
                Console.WriteLine("Enter Y co-ordinate for point two");
                x = Validate.Validate.ValidateNumber(Console.ReadLine());


                Console.WriteLine("Enter Y co-ordinate for point two");
                y = Validate.Validate.ValidateNumber(Console.ReadLine());
                //ICanvasService canvasService = FactoryCanvas.GetCanvas();
                //string[,] canvasStorage = canvasService.DrawingCanvas(canvas);
                //Canvas canvas = new Canvas();
                canvas.PointTwo = new Point(x, y);

                logger.Info("canvas with co-ordinate x1 => " + canvas.PointOne.X + " y1 => " + canvas.PointOne.Y +
                                " x2 => " + canvas.PointTwo.X + " y2 => " + canvas.PointTwo.Y);

                ICanvasService canvasService = FactoryCanvas.GetCanvas();
                string[,] canvasStarage = canvasService.DrawingCanvas(canvas);

                PrintingCanvas(canvasStarage);

                do
                {
                    Console.WriteLine("enter your choice");
                    Console.WriteLine("1 . line");
                    Console.WriteLine("2 . rectangle");
                    Console.WriteLine("3 . circle");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Line line = new Line();
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for point one");
                            x = Validate.Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point one");
                            y = Validate.Validate.ValidateNumber(Console.ReadLine());
                            line.PointOne = new Point(x, y);
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for point one");
                            x = Validate.Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point one");
                            y = Validate.Validate.ValidateNumber(Console.ReadLine());
                            line.PointTwo = new Point(x, y);


                            ILineService lineService = FactoryLine.GetLine();
                            canvasStarage = lineService.DrawingLine(line, canvasStarage, canvas);

                            logger.Info("Line with co-ordinate x1 => " + line.PointOne.X + " y1 => " + line.PointOne.Y +
                               " x2 => " + line.PointTwo.X + " y2 => " + line.PointTwo.Y);
                            PrintingCanvas(canvasStarage);

                            break;
                        case "2":
                            Entity.Rectangle rectangle = new Entity.Rectangle();
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for point one");
                            x = Validate.Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point one");
                            y = Validate.Validate.ValidateNumber(Console.ReadLine());
                            rectangle.PointOne = new Point(x, y);
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for point one");
                            x = Validate.Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for point one");
                            y = Validate.Validate.ValidateNumber(Console.ReadLine());
                            rectangle.PointTwo = new Point(x, y);

                            IRectangleService rectangleService = FactoryRectangle.GetRectangle();
                            canvasStarage = rectangleService.DrawingRectangle(rectangle, canvasStarage, canvas);
                            logger.Info("Rectangle with co-ordinate x1 => " + rectangle.PointOne.X + " y1 => " + rectangle.PointOne.Y +
                                " x2 => " + rectangle.PointTwo.X + " y2 => " + rectangle.PointTwo.Y);
                            PrintingCanvas(canvasStarage);
                           
                            break;
                        case "3":
                            Entity.Circle circle = new Entity.Circle();
                            Console.WriteLine("Enter values for co-ordinates");
                            Console.WriteLine("Enter X co-ordinate for circle");
                            x = Validate.Validate.ValidateNumber(Console.ReadLine());
                            Console.WriteLine("Enter Y co-ordinate for circle");
                            y = Validate.Validate.ValidateNumber(Console.ReadLine());
                            circle.PointOne = new Point(x, y);
                            Console.WriteLine("Enter radius");
                            circle.Radius = Validate.Validate.ValidateNumber(Console.ReadLine());
                            ICircleService circleService = FactoryCircle.GetCircle();
                            canvasStarage = circleService.DrawingCircle(circle, canvasStarage, canvas);
                            PrintingCanvas(canvasStarage);
                            break;
                    }
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        

        private static void PrintingCanvas(string[,] canvasStarage)
        {
            for (int i = 0; i < canvasStarage.GetLength(0); i++)
            {
                for (int j = 0; j < canvasStarage.GetLength(1); j++)
                {
                    Console.Write(canvasStarage[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
