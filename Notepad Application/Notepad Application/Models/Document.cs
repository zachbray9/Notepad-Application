using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad_Application
{
    public class Document
    {
        public string FileName { get; set; }

        public string FilePath { get; set; }
        public string text { get; set; }

        public Document(string fileName = "Untitled")
        {
            FileName = fileName;
        }
    }
}
