using andy250.Sandbox.SmartMap.Test.Entities;

namespace andy250.Sandbox.SmartMap.Test.EntityMappers
{
    public class UserMapBinder : IMapper<BinderModel, ModelUser>
    {
        public ModelUser Map(BinderModel item)
        {
            return new ModelUser
            {
                Id = item.Id
            };
        }
    }
}