using System;
using Services;
using Entity;
using Microsoft.Practices.Unity;

namespace Factory
{
    public class FactoryCircle
    {
        public static ICircleService GetCircle()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICircleService, CircleService>();
            CircleService circleService = unityContainer.Resolve<CircleService>();
            return circleService;
            //throw new NotImplementedException();
        }
    }
}