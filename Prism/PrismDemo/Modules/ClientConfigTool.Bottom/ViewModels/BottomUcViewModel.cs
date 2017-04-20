using EventAggregation.Infrastructure;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientConfigTool.Bottom.ViewModels
{
    public class BottomUcViewModel: BindableBase
    {
        private readonly IRegionManager _regionManager;
        IEventAggregator eventAggreator;
        public DelegateCommand ModuleSetCommand { get; private set; }
        public DelegateCommand SNAPCommand { get; private set; }
        //public ICommand OtherCommand { get; private set; }
        public BottomUcViewModel()
        {
            this._regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            ModuleSetCommand = new DelegateCommand(OpenModuelSet);
            SNAPCommand = new DelegateCommand(SnapMethod);
            //OtherCommand = new DelegateCommand(() => 
            //{
            //    string name = "";
            //});
            //GlobalCommand.Infrastructure.GlobalCommands.OpenCommand.RegisterCommand(OtherCommand);
            //eventAggreator = MyEventAggregator.GetEventAggregator();
             eventAggreator = ServiceLocator.Current.GetInstance<IEventAggregator>();
        }
        private void OpenModuelSet()
        {
            Message message = new Message()
            {
                SentTo = "Shell",
                /*SentTo = this._regionManager.Regions["ContentRegion"].ActiveViews.First().GetType().Name*/
                type = MessageType.OPEN_MODULE_VIEW,
                CallBackAction = new Action<object>(obj => 
                {

                })
            };
            this.eventAggreator.GetEvent<MessageSentEvent>().Publish(message);
        }
        private void SnapMethod()
        {
            Message message = new Message()
            {
                SentTo = "RealTimeMonitorUc",
                type = MessageType.SNAP
            };
            this.eventAggreator.GetEvent<MessageSentEvent>().Publish(message);
        }
    }
}
