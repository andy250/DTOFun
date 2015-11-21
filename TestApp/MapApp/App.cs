using System;
using System.Collections.Generic;
using Ninject;

namespace andy250.Sandbox.TestApp.MapApp
{
    public class App
    {
        private IKernel kernel;

        public App()
        {
            //kernel.Bind<IMapper<DTOProduct, Model>>().To<ProductMap>();
            //kernel.Bind<IMapper<DTOUser, Model>>().To<UserMap>();

            
        }

        public void Run()
        {
        }
    }
}
