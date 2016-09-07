using Entity;

namespace Services
{
    public interface ICircleService
    {
        string[,] DrawingCircle(Circle circle, string[,] canvasStaorage, Canvas canvas);
    }
}