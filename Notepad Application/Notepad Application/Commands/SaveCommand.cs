using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_Application.Commands
{
    class SaveCommand : CommandBase
    {
        private DocumentViewModel DocumentViewModel;

        public SaveCommand(DocumentViewModel documentViewModel)
        {
            DocumentViewModel = documentViewModel;
        }

        public override void Execute(object parameter)
        {
            if (DocumentViewModel.FilePath == null)
            {
                SaveFileDialog saveFileDialogue = new SaveFileDialog();
                saveFileDialogue.DefaultExt = ".txt";
                saveFileDialogue.Filter = "Text Document (.txt)|*.txt";
                if (saveFileDialogue.ShowDialog() == true)
                {
                    DocumentViewModel.FilePath = saveFileDialogue.FileName;
                    DocumentViewModel.FileName = Path.GetFileName(DocumentViewModel.FilePath);
                    File.WriteAllText(DocumentViewModel.FilePath, DocumentViewModel.Text);
                }
            }
            else
            { 
                File.WriteAllText(DocumentViewModel.FilePath, DocumentViewModel.Text);
            }
        }
    }
}
