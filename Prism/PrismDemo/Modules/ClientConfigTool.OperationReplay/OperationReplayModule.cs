using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConfigTool.OperationReplay
{
    public class OperationReplayModule : IModule
    {
        private IRegionManager _regionManager;
        public OperationReplayModule(IRegionManager _regionManager)
        {
            this._regionManager = _regionManager;
        }
        public void Initialize()
        {
            this._regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.OperationReplayUc));
        }
    }
}
