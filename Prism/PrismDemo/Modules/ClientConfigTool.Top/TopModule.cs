using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConfigTool.Top
{
    public class TopModule : IModule
    {
        private IRegionManager _regionManager;
        public TopModule()
        {
            _regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("TopTitleRegion", typeof(Views.TopTitleUc));
        }
    }
}
