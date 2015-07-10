using System;

namespace ConsoleApplication1
{
    using System.Collections.Generic;

    public interface IApp
    {
        void Run();
    }

    public class App : IApp
    {
        private IMapper mapper;

        public App(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void Run()
        {
            var dtos = new List<DTO>();
            dtos.Add(new DTOProduct { Id = "123" });
            dtos.Add(new DTOUser() { Name = "user1" });

            var models = mapper.Map(dtos);

            models.ForEach(x => Console.WriteLine(x.ToString()));

            Console.ReadLine();
        }
    }
}
