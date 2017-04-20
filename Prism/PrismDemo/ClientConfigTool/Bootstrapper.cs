using System.Windows;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;

namespace ClientConfigTool
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.RegisterType(typeof(IEventAggregator), typeof(EventAggregator));
        }
        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ClientConfigTool.Top.TopModule));
            catalog.AddModule(typeof(ClientConfigTool.Nav.NavMenuModule));
            catalog.AddModule(typeof(ClientConfigTool.Bottom.BottomModule));
            catalog.AddModule(typeof(ClientConfigTool.RealTimeMonitor.RealTimeMonitorModule));
            catalog.AddModule(typeof(ClientConfigTool.ReplayMonitor.ReplayMonitorModule));
            catalog.AddModule(typeof(ClientConfigTool.OperationReplay.OperationReplayModule));
            //base.ConfigureModuleCatalog();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
