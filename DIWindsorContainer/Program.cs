/* 1. Vytvorenie kontajneru
 * 2. Vytvorenie instalatoru
 * 3. Pridanie instalatoru do Main programu
 * 
 */

using Castle.Windsor;
using Castle.Windsor.Installer;

namespace DIWindsorContainer
{
    class Program
    {
        static void Main()
        {
            // 1. vytvorenie windsor kontajneru
            IWindsorContainer container = new WindsorContainer();

            // 2. pridanie instalatoru
            container.Install(new FooWindsorInstaller());

            // 3. pouzitie kontajneru
            var myObject = container.Resolve<Michal>();

            // 4. na konci aplikacie sa musi zavolat dispose
            container.Dispose();
        }
    }
}
