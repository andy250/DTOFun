using andy250.Sandbox.SmartMap.Test.Entities;

namespace andy250.Sandbox.SmartMap.Test.EntityMappers
{
    public class ProductMap : IMapper<DTOProduct, ModelProduct>
    {
        public ModelProduct Map(DTOProduct item)
        {
            return new ModelProduct
            {
                Id = item.Id,
                Price = item.Price
            };
        }
    }
}