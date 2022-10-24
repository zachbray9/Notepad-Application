using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_Application.Commands
{
    class NewCommand : CommandBase
    {
        private DocumentViewModel DocumentViewModel;

        public NewCommand(DocumentViewModel documentViewModel)
        {
            DocumentViewModel = documentViewModel;
        }
        public override void Execute(object parameter)
        {
            //DocumentViewModel.currentDocument = new Document();
            DocumentViewModel.FileName = null;
            DocumentViewModel.FilePath = null;
            DocumentViewModel.Text = null;
        }
    }
}
