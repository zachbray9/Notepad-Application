using Notepad_Application.Commands;
using Notepad_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad_Application
{
    public class DocumentViewModel : ViewModelBase
    {
        private Document currentDocument;

        public DocumentViewModel()
        {
            //NewCommand = new NewCommand();
            //NewWindowCommand = new NewWindowCommand();
            OpenCommand = new OpenCommand(this);
            SaveCommand = new SaveCommand(this);
            //SaveAsCommand = new SaveAsCommand();
            ExitCommand = new ExitCommand();
            currentDocument = new Document();
        }

        private string text;
        public string Text
        {
            get
            {
                return currentDocument.Text;
                //return text;
            }
            set
            {
                currentDocument.Text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        private string fileName;
        public string FileName
        {
            get
            {
                return currentDocument.FileName;
            }
            set
            {
                currentDocument.FileName = value;
                OnPropertyChanged(nameof(FileName));
            }
        }

        private string filePath;
        public string FilePath
        {
            get
            {
                return currentDocument.FilePath;
            }
            set
            {
                currentDocument.FilePath = value;
            }
        }

        public ICommand NewCommand
        {
            get;
        }

        public ICommand NewWindowCommand
        {
            get;
        }

        public ICommand OpenCommand
        {
            get;
        }

        public ICommand SaveCommand
        {
            get;
        }

        public ICommand SaveAsCommand
        {
            get;
        }

        public ICommand ExitCommand
        {
            get;
        }

        
    }
}
