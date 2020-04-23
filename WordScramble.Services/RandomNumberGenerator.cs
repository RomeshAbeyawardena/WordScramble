using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Services
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random random;

        public int GetRandomNumber(int maximum, int minimum = 0)
        {
            return random.Next(minimum, maximum);
        }

        public RandomNumberGenerator(Random random)
        {
            this.random = random;
        }
    }
}
