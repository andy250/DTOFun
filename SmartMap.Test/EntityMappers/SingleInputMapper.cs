using System;
using System.Collections.Generic;
using andy250.Sandbox.SmartMap.Test.Entities;

namespace andy250.Sandbox.SmartMap.Test.EntityMappers
{
    public class SingleInputMapper : SmartMapper<BinderModel, Model>
    {
        private static readonly IDictionary<string, Type> matrix = new Dictionary<string, Type>
        {
            { "Product", typeof(ModelProduct) },
            { "User", typeof(ModelUser) }
        };

        public SingleInputMapper(IMapperResolver resolver) : base(resolver)
        { }

        protected override Type GetTargetType(BinderModel item)
        {
            return matrix[item.Type];
        }
    }
}
