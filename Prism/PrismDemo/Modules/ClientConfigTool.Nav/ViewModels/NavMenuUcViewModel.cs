using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConfigTool.Nav.ViewModels
{
    public class NavMenuUcViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavCommand { get; private set; }
        public NavMenuUcViewModel()
        {
            this._regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            NavCommand = new DelegateCommand<string>(NavMethod);
        }
        private void NavMethod(string NavPath)
        {
            if (!string.IsNullOrEmpty(NavPath))
            {
                this._regionManager.RequestNavigate("ContentRegion", new Uri(NavPath, UriKind.Relative));
            }
        }
    }
}
