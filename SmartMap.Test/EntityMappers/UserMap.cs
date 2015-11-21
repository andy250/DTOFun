using andy250.Sandbox.SmartMap.Test.Entities;

namespace andy250.Sandbox.SmartMap.Test.EntityMappers
{
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
}