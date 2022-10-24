using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_Application
{
    public class Document
    {
        public Document()
        {

        }

        private string fileName;
        public string FileName 
        {
            get
            {
                if (fileName == null)
                    return "Untitled - Notepad";
                else
                    return fileName;
            }

            set
            {
                if (value == null)
                    fileName = $"Untitled - Notepad";
                else
                    fileName = $"{value} - Notepad";
            }
        }

        public string FilePath { get; set; }
        public string Text { get; set; }

        
    }
}
