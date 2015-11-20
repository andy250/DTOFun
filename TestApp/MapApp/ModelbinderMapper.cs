using andy250.Sandbox.SmartMap;
using System;
using System.Collections.Generic;

namespace andy250.Sandbox.TestApp.MapApp
{
    public class ModelbinderMapper : SmartMapper<BinderModel, Model>
    {
        private static IDictionary<string, Type> matrix = new Dictionary<string, Type>
        {
            { "Product", typeof(ModelProduct) },
            { "User", typeof(ModelUser) }
        };

        public ModelbinderMapper(IMapperResolver resolver) : base(resolver)
        { }

        protected override Type GetTargetType(BinderModel item)
        {
            return matrix[item.Type];
        }
    }
}
