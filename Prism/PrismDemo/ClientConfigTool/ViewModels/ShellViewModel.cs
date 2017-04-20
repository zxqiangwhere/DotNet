using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConfigTool.ViewModels
{
    public class ShellViewModel: BindableBase
    {
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavCommand { get; private set; }
        public ShellViewModel()
        {
            this._regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            NavCommand = new DelegateCommand<string>(Navigate);
        }
        private void Navigate(string NavPath)
        {
            //this._regionManager.AddToRegion("ContentRegion", typeof(ClientConfigTool.RealTimeMonitor.Views.RealTimeMonitorUc));
            if (!string.IsNullOrEmpty(NavPath))
            {
                this._regionManager.RequestNavigate("ContentRegion", new Uri(NavPath,UriKind.Relative), new Action<NavigationResult>(result =>
                {
                    var re = result;
                }));
            }
        }
    }
}
