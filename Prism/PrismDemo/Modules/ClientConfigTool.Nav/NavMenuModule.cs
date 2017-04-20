using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConfigTool.Nav
{
    public class NavMenuModule : IModule
    {
        private IRegionManager _regionManager;
        public NavMenuModule(IRegionManager _regionManager)
        {
            this._regionManager = _regionManager;
        }
        public void Initialize()
        {
            this._regionManager.RegisterViewWithRegion("NavMenuRegion", typeof(Views.NavMenuUc));
        }
    }
}
