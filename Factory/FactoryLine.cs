using System;
using Services;
using Microsoft.Practices.Unity;

namespace Factory
{
    public class FactoryLine
    {
        public static LineService GetLine()
        {
            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<ILineService,LineService>();
            LineService lineService = unityContainer.Resolve<LineService>();
            return lineService; //throw new NotImplementedException();
            throw new NotImplementedException();
        }
    }
}