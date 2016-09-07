using Entity;

namespace Services
{
    public interface IRectangleService
    {
        string[,] DrawingRectangle(Rectangle rectangle,string[,] canvasStorage,Canvas canvas);
    }
}