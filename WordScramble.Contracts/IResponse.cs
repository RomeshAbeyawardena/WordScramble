using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Contracts
{
    public interface IResponse<TResult>
    {
        bool IsValid { get; }
        TResult Result { get; }
        IEnumerable<ValidationFailure> Errors { get; }
    }
}
