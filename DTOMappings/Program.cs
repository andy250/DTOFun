using Ninject;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IMapper>().To<Mapper>();
            kernel.Bind<IApp>().To<App>();

            var app = kernel.Get<IApp>();
            app.Run();
        }
    }
}
