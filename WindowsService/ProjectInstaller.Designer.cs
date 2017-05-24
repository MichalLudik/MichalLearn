namespace WindowsService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MlTestProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.MlTestServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // MlTestProcessInstaller
            // 
            this.MlTestProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.MlTestProcessInstaller.Password = null;
            this.MlTestProcessInstaller.Username = null;
            // 
            // MlTestServiceInstaller
            // 
            this.MlTestServiceInstaller.ServiceName = "MlTestService";
            this.MlTestServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.MlTestServiceInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.MlTestServiceInstaller_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.MlTestProcessInstaller,
            this.MlTestServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller MlTestProcessInstaller;
        private System.ServiceProcess.ServiceInstaller MlTestServiceInstaller;
    }
}