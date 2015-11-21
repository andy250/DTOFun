using System.Collections.Generic;
using andy250.Sandbox.SmartMap.Test.Entities;
using andy250.Sandbox.SmartMap.Test.EntityMappers;
using Moq;
using Xunit;

namespace andy250.Sandbox.SmartMap.Test
{
    public class SingleInputMapperTest
    {
        private readonly ISmartMapper<BinderModel, Model> mapper;

        public SingleInputMapperTest()
        {
            var resovler = new Mock<IMapperResolver>();
            mapper = new SingleInputMapper(resovler.Object);

            var productMap = new ProductMapBinder();
            var userMap = new UserMapBinder();

            resovler.Setup(x => x.Resolve(typeof (IMapper<BinderModel, ModelProduct>))).Returns(productMap);
            resovler.Setup(x => x.Resolve(typeof (IMapper<BinderModel, ModelUser>))).Returns(userMap);
        }

        [Fact]
        public void MapListOfSingleTypes_ShouldReturnListOfVariousModels()
        {
            var bms = new List<BinderModel>();
            bms.Add(new BinderModel { Type = "User", Id = "7" });
            bms.Add(new BinderModel { Type = "Product", Id = "8" });

            var models = mapper.Map(bms);

            Assert.Equal(bms.Count, models.Count);
        }
    }
}
