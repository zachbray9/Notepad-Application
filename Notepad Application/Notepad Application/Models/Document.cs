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

        /*public Document(string fileName = null, string filePath, string text)
        {
            FileName = fileName;
            filePath = FilePath;
            Text = text;
        }
        */

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
                fileName = $"{value} - Notepad";
            }
        }

        public string FilePath { get; set; }
        public string Text { get; set; }

        
    }
}
