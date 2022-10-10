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

        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                //PropertyChanged(Text);
            }
        }

        private string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
                //PropertyChanged(FileName);
            }
        }

        private string filePath;
        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
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
        
    }
}
