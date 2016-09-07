using Entity;

namespace Services
{
    public interface ICanvasService
    {
        string[,] DrawingCanvas(Canvas shape);
    }
}