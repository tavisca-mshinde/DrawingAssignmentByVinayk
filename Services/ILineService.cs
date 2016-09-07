using System;
using Entity;

namespace Services
{
    public interface ILineService
    {
        string[,] DrawingLine(Line line,string[,] canvasStaorage,Canvas canvas);
        //{
        //    throw new NotImplementedException();
        //}
    }
}