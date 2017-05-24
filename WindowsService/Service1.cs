using System;
using System.IO;
using System.ServiceProcess;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt");
        }

        protected override void OnStop()
        {
            File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStop.txt");
        }
    }
}
