using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Contracts
{
    public interface IRandomNumberGenerator
    {
        int GetRandomNumber(int maximum, int minimum = 0);
    }
}
