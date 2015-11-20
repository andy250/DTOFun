using andy250.Sandbox.SmartMap;
using Ninject;
using System;

namespace andy250.Sandbox.TestApp.MapApp
{
    public class NinjectMapperResolver : IMapperResolver
    {
        private IKernel kernel;

        public NinjectMapperResolver(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public dynamic Resolve(Type mapperType)
        {
            return kernel.Get(mapperType);
        }
    }
}
