using System;
using System.Collections.Generic;
using System.Linq;

namespace andy250.Sandbox.SmartMap
{
    public class SmartMapper<TSrc, TDest> : ISmartMapper<TSrc, TDest>
    {
        private readonly IMapperResolver resolver;

        public SmartMapper(IMapperResolver resolver)
        {
            this.resolver = resolver;
        }

        public List<TDest> Map(IEnumerable<TSrc> dataToMap)
        {
            if (dataToMap != null && dataToMap.Any())
            {
                return dataToMap.Select(Map).ToList();
            }
            return new List<TDest>();
        }

        public TDest Map(TSrc item)
        {
            if (item != null)
            {
                return GetMapper(item).Map((dynamic) item);
            }
            return default(TDest);
        }

        private dynamic GetMapper(TSrc item)
        {
            var mt = typeof(IMapper<,>).MakeGenericType(GetSourceType(item), GetTargetType(item));
            return resolver.Resolve(mt);
        }

        protected virtual Type GetSourceType(TSrc item)
        {
            return item.GetType();
        }

        protected virtual Type GetTargetType(TSrc item)
        {
            return typeof(TDest);
        }
    }
}
