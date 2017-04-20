using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConfigTool.Bottom
{
    public class BottomModule : IModule
    {
        private IRegionManager _regionManager;
        public BottomModule(IRegionManager _regionManager)
        {
            this._regionManager = _regionManager;
        }
        public void Initialize()
        {
            this._regionManager.RegisterViewWithRegion("BottomRegion", typeof(Views.BottomUc));
        }
    }
}
