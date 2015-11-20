using System;

namespace andy250.Sandbox.SmartMap
{
    public interface IMapperResolver
    {
        dynamic Resolve(Type mapperType);
    }
}
