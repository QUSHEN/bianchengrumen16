using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDemo
{
    public class FileInformation
    {
        public string FileName { set; get; }
        public string FileSize { set; get; }

        public FileInformation(string filename, string filesize)
        {
            FileName = filename;
            FileSize = filesize;
        }
    }
}
