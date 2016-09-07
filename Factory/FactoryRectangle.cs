using System;
using Services;
using Microsoft.Practices.Unity;

namespace Factory
{
    public class FactoryRectangle
    {
        public static RectangleService GetRectangle()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IRectangleService, RectangleService>();
            RectangleService rectangleService = unityContainer.Resolve<RectangleService>();
            return rectangleService; //throw new NotImplementedException();
            //throw new NotImplementedException();
            //throw new NotImplementedException();
        }
    }
}