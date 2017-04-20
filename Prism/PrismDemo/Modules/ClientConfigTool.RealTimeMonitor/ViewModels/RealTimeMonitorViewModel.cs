using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientConfigTool.RealTimeMonitor.ViewModels
{
    public class RealTimeMonitorViewModel : BindableBase, INavigationAware
    {
        private string _message;
        public ICommand OtherCommand { get; private set; }

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                SetProperty(ref this._message, value);
            }
        }

        public RealTimeMonitorViewModel()
        {
            OtherCommand = new DelegateCommand<string>(str =>
            {
                Message = "Execute Global Command";
            });
            GlobalCommand.Infrastructure.GlobalCommands.OpenCommand.RegisterCommand(OtherCommand);
            
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }
    }
}
