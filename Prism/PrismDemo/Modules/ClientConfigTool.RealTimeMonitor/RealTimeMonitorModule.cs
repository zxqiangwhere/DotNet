using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConfigTool.RealTimeMonitor
{
    public class RealTimeMonitorModule : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer container;
        public RealTimeMonitorModule(IRegionManager _regionManager, IUnityContainer container)
        {
            this._regionManager = _regionManager;
            //this._regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            //this.container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            this.container = container;
        }
        public void Initialize()
        {
            this._regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.RealTimeMonitorUc));
            //container.RegisterTypeForNavigation<Views.RealTimeMonitorUc>("RealTimeMonitorRegion");
            //container.RegisterTypeForNavigation<Views.RealTimeMonitorUc>();

        }
    }
}
