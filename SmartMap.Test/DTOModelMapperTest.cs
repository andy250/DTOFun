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
        public void MapNullEntity_ShouldThrow_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { mapper.Map((DTO)null); });
        }

        [Fact]
        public void MapNullEntityList_ShouldThrow_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { mapper.Map((List<DTO>) null); });
        }

        [Fact]
        public void MapEmptyEntityList_ShouldReturnEmptyModelList()
        {
            var result = mapper.Map(new List<DTO>());
            Assert.NotNull(result);
            Assert.Equal(0, result.Count);
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

            Assert.Equal(dtos[0].Id, models[0].Id);
            Assert.Equal(dtos[1].Id, models[1].Id);
            Assert.Equal(dtos[2].Id, models[2].Id);

            Assert.Equal(typeof(ModelProduct), models[0].GetType());
            Assert.Equal(typeof(ModelProduct), models[1].GetType());
            Assert.Equal(typeof(ModelUser), models[2].GetType());
        }
    }
}
