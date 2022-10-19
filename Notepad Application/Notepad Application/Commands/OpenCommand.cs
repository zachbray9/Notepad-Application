using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_Application.Commands
{
    public class OpenCommand : CommandBase
    {
        DocumentViewModel DocumentViewModel;

        public OpenCommand(DocumentViewModel documentViewModel)
        {
            DocumentViewModel = documentViewModel;
        }
        public override void Execute(object parameter)
        {

            OpenFileDialog openFileDialogue = new OpenFileDialog();
            openFileDialogue.DefaultExt = ".txt";
            openFileDialogue.Filter = "Text Document (.txt)|*.txt";
            if (openFileDialogue.ShowDialog() == true)
            {
                DocumentViewModel.FilePath = openFileDialogue.FileName;
                DocumentViewModel.FileName = System.IO.Path.GetFileName(DocumentViewModel.FilePath);
                DocumentViewModel.Text = File.ReadAllText(DocumentViewModel.FilePath);
            }
        }
    }
}
