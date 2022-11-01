using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Notepad_Application.Commands
{
    class ExitCommand : CommandBase
    {
        private DocumentViewModel DocumentViewModel;

        public ExitCommand(DocumentViewModel documentViewModel)
        {
            DocumentViewModel = documentViewModel;
        }

        public override void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
