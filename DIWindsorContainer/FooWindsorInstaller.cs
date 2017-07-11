// Vytvorenie instalatora


using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace DIWindsorContainer
{
    public class FooWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<Michal>());
            container.Register(Component.For<IDependency1>().ImplementedBy<Dependency1>());
            container.Register(Component.For<IDependency2>().ImplementedBy<Dependency2>());
        }
    }
}