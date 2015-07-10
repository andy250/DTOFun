using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public interface IMapper
    {
        List<Model> Map(List<DTO> dtos);
    }

    public class Mapper : IMapper
    {
        public List<Model> Map(List<DTO> dtos)
        {
            throw new NotImplementedException();
        }
    }
}
