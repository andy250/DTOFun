using System;
using System.Collections.Generic;
using Ninject;
using System.Linq;
using andy250.Sandbox.SmartMap;

namespace andy250.Sandbox.TestApp.MapApp
{
    public class App
    {
        private IKernel kernel;

        public App()
        {
            kernel = new StandardKernel();

            kernel.Bind<IMapperResolver>().To<NinjectMapperResolver>();

            kernel.Bind(typeof(ISmartMapper<BinderModel,Model>)).To(typeof(ModelbinderMapper));
            kernel.Bind(typeof(ISmartMapper<,>)).To(typeof(SmartMapper<,>));

            kernel.Bind<IMapper<DTOProduct, Model>>().To<ProductMap>();
            kernel.Bind<IMapper<DTOUser, Model>>().To<UserMap>();

            kernel.Bind<IMapper<BinderModel, ModelProduct>>().To<ProductMap2>();
            kernel.Bind<IMapper<BinderModel, ModelUser>>().To<UserMap2>();
        }

        public void Run()
        {
            var dtos = new List<DTO>();

            dtos.Add(new DTOProduct { Id = "123", Price = 9776.32 });
            dtos.Add(new DTOProduct { Id = "124", Price = 132.99 });
            dtos.Add(new DTOUser { Id = "2345", Name = "user1" });

            var models = kernel.Get<ISmartMapper<DTO, Model>>().Map(dtos).ToList();
            models.ForEach(x => Console.WriteLine(x.ToString()));

            var bms = new List<BinderModel>();
            bms.Add(new BinderModel { Type = "User", Id = "7" });
            bms.Add(new BinderModel { Type = "Product", Id = "8" });


            Console.WriteLine();

            var models2 = kernel.Get<ISmartMapper<BinderModel, Model>>().Map(bms).ToList();
            models2.ForEach(x => Console.WriteLine(x.ToString()));

            Console.ReadLine();
        }
    }
}
