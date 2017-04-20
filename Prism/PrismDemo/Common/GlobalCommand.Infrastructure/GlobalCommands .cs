using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalCommand.Infrastructure
{
    public static class GlobalCommands
    {
        public static CompositeCommand OpenCommand = new CompositeCommand();
    }
}
