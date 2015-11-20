using andy250.Sandbox.SmartMap;

namespace andy250.Sandbox.TestApp.MapApp
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

    public class UserMap : IMapper<DTOUser, ModelUser>
    {
        public ModelUser Map(DTOUser item)
        {
            return new ModelUser
            {
                Id = item.Id,
                Name = item.Name
            };
        }
    }

    public class UserMap2 : IMapper<BinderModel, ModelUser>
    {
        public ModelUser Map(BinderModel item)
        {
            return new ModelUser
            {
                Id = item.Id
            };
        }
    }

    public class ProductMap2 : IMapper<BinderModel, ModelProduct>
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
