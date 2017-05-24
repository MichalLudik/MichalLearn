using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace WindowsService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void MlTestServiceInstaller_AfterInstall(object sender, InstallEventArgs e)
        {
            new ServiceController(MlTestServiceInstaller.ServiceName).Start();
        }
    }
}
