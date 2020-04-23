using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;

namespace WordScramble.Domains.Extensions
{
    public static class ObjectExtensions
    {
        public static T Configure<T>(this T response, Action<T> configureAction)
        {
            configureAction(response);
            return response;
        }
    }
}
