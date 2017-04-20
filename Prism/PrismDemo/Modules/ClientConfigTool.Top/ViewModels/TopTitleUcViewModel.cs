using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;


namespace ClientConfigTool.Top.ViewModels
{
    public class TopTitleUcViewModel : BindableBase
    {
        private string _Title;

        public string Title
        {
            get
            {
                return _Title;
            }

            set
            {
                SetProperty(ref this._Title, value);
            }
        }
        public TopTitleUcViewModel()
        {
            Title = "配置工具";
        }
    }
}
