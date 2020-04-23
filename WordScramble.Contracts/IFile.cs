using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Contracts
{
    public interface IFile
    {
        bool Exists { get; }
        string Path { get; }
        string FileName { get; }
        string Extension { get; }
        StreamReader OpenText();
    }
}
