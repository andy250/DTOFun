using andy250.Sandbox.SmartMap.Test.Entities;

namespace andy250.Sandbox.SmartMap.Test.EntityMappers
{
    public class ProductMapBinder : IMapper<BinderModel, ModelProduct>
    {
        public ModelProduct Map(BinderModel item)
        {
            return new ModelProduct
            {
                Id = item.Id
            };
        }
    }
}
