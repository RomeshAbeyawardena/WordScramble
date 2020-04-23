using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Domains.Extensions
{
    public static class FileExtensions
    {
        public static IFile GetFile(string path)
        {
            return new DefaultFile(path);
        }
    }
}
