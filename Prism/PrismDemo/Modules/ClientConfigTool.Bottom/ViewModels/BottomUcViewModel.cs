using EventAggregation.Infrastructure;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
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
        public InteractionRequest<INotification> CustomPopupViewRequest { get; private set; }
        public Action MessageDialogAction { get; private set; }
        public BottomUcViewModel()
        {
            this._regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            ModuleSetCommand = new DelegateCommand(OpenModuelSet);
            SNAPCommand = new DelegateCommand(SnapMethod);
            MessageDialogAction = new Action(() => 
            {
                string name = "";
            });
             eventAggreator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            this.CustomPopupViewRequest = new InteractionRequest<INotification>();
        }
        private void OpenModuelSet()
        {
            this.CustomPopupViewRequest.Raise(new Notification { Content = "this is Message Show", Title = "Custom Message Dialog" }, result => 
            {
                string nnn = "";
            });
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
