using System;
using Factory;
using Services;
using Microsoft.Practices.Unity;
using Entity;

namespace Factory
{
    public class FactoryCanvas
    {
        public static CanvasService GetCanvas()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICanvasService,CanvasService>();
            CanvasService canvasService = unityContainer.Resolve<CanvasService>();
            return canvasService; //throw new NotImplementedException();
        }
    }
}