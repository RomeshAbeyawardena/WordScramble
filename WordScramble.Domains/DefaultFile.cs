using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Domains
{
    public class DefaultFile : IFile
    {
        private readonly FileInfo fileInfo;

        public DefaultFile(string path)
        {
            Path = path;
            fileInfo = new FileInfo(path);
        }

        public bool Exists => fileInfo.Exists;

        public string Path { get; }

        public string FileName => fileInfo.Name;

        public string Extension => fileInfo.Extension;

        public StreamReader OpenText()
        {
            return fileInfo.OpenText();
        }
    }
}
