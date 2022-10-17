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
        public string FileName { get; set; }

        public string FilePath { get; set; }
        public string Text { get; set; }

        
    }
}
