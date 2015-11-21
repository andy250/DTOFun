using System;
using System.Collections.Generic;
using System.Linq;
using andy250.Sandbox.SmartMap.Test.Entities;
using andy250.Sandbox.SmartMap.Test.EntityMappers;
using Moq;
using Xunit;

namespace andy250.Sandbox.SmartMap.Test
{
    public class DTOModelMapperTest
    {
        private readonly ISmartMapper<DTO, Model> mapper;

        public DTOModelMapperTest()
        {
            var resolver = new Mock<IMapperResolver>();
            mapper = new SmartMapper<DTO, Model>(resolver.Object);

            var productMap = new ProductMap();
            var userMap = new UserMap();

            resolver.Setup(x => x.Resolve(typeof (IMapper<DTOProduct, Model>))).Returns(productMap);
            resolver.Setup(x => x.Resolve(typeof (IMapper<DTOUser, Model>))).Returns(userMap);
        }

        [Fact]
        public void MapNullEntity_ShouldReturnNull()
        {
            var result = mapper.Map((DTO)null);
            Assert.Null(result);
        }

        [Fact]
        public void MapListOfVariousDTOs_ShouldReturnListOfVariousModels()
        {
            var dtos = new List<DTO>();

            dtos.Add(new DTOProduct { Id = "123", Price = 9776.32 });
            dtos.Add(new DTOProduct { Id = "124", Price = 132.99 });
            dtos.Add(new DTOUser { Id = "2345", Name = "user1" });

            var models = mapper.Map(dtos);

            Assert.Equal(dtos.Count, models.Count);
        }
    }
}
