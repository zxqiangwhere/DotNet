using EventAggregation.Infrastructure;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientConfigTool
{
    /// <summary>
    /// Shell.xaml 的交互逻辑
    /// </summary>
    public partial class Shell : Window
    {
        IEventAggregator eventAggreator;
        public Shell()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.ShellViewModel();
            //this.eventAggreator = EventAggregation.Infrastructure.MyEventAggregator.GetEventAggregator();
            this.eventAggreator = eventAggreator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            eventAggreator.GetEvent<MessageSentEvent>().Subscribe(new Action<Message>(message =>
            {
                switch (message.type)
                {
                    case MessageType.OPEN_MODULE_VIEW:
                        break;
                    case MessageType.SNAP:
                        break;
                    default:
                        break;
                }
            }), ThreadOption.PublisherThread, false,
            filter => filter.SentTo == "Shell");
        }
    }
}
