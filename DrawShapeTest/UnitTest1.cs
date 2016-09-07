using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using System.Drawing;
using Services;
using Factory;

namespace DrawShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Canvas canvas = new Canvas();
            canvas.PointOne = new Point(10, 10);
            canvas.PointTwo = new Point(40, 40);

            ICanvasService canvasService = FactoryCanvas.GetCanvas();
            string[,] str = canvasService.DrawingCanvas(canvas);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Canvas canvas = new Canvas();
            canvas.PointOne = new Point(10, 10);
            canvas.PointTwo = new Point(40, 40);

            ICanvasService canvasService = FactoryCanvas.GetCanvas();
            string[,] canvasStaorage = canvasService.DrawingCanvas(canvas);

            Line line = new Line();
            line.PointOne = new Point(10, 10);
            line.PointTwo = new Point(40, 40);

            ILineService lineService = FactoryLine.GetLine();
            string[,] str = lineService.DrawingLine(line, canvasStaorage, canvas);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Canvas canvas = new Canvas();
            canvas.PointOne = new Point(10, 10);
            canvas.PointTwo = new Point(40, 40);

            ICanvasService canvasService = FactoryCanvas.GetCanvas();
            string[,] canvasStaorage = canvasService.DrawingCanvas(canvas);

            Entity.Rectangle rectangle = new Entity.Rectangle();
            rectangle.PointOne = new Point(10, 10);
            rectangle.PointTwo = new Point(40, 40);

            IRectangleService rectangleService = FactoryRectangle.GetRectangle();
            string[,] str = rectangleService.DrawingRectangle(rectangle, canvasStaorage, canvas);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Canvas canvas = new Canvas();
            canvas.PointOne = new Point(10, 10);
            canvas.PointTwo = new Point(40, 40);

            ICanvasService canvasService = FactoryCanvas.GetCanvas();
            string[,] canvasStaorage = canvasService.DrawingCanvas(canvas);

            Entity.Circle circle = new Entity.Circle();
            circle.PointOne = new Point(10, 10);
            circle.Radius= 10;
            ICircleService circleService = FactoryCircle.GetCircle();
            string[,] str = circleService.DrawingCircle(circle, canvasStaorage, canvas);
        }
    }
}
