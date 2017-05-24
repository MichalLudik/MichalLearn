//manualne nainstalovanie servisy -> cmd: installutil servisa.exe

using System.ServiceProcess;

namespace WindowsService
{
    static class Servisa
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG //spusti sa v pripade ze nastavim kompilator na DEBUG
            Service1 myService = new Service1();
            myService.OnDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

#else //kompilator na RELEASE
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}