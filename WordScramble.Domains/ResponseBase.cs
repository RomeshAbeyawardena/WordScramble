using FluentValidation.Results;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Contracts;
using WordScramble.Domains.Extensions;

namespace WordScramble.Domains
{
    public abstract class ResponseBase<TResult> : IResponse<TResult>
    {
        protected ResponseBase()
        {

        }

        public bool IsValid { get; private set; }

        public TResult Result { get; private set; }

        public IEnumerable<ValidationFailure> Errors { get; private set; }

        public static TResponse Success<TResponse>(TResult result)
            where TResponse : IResponse<TResult>
        {
            return Activator.CreateInstance<TResponse>().Configure(response => { 
                var responseBase = response as ResponseBase<TResult>;
                responseBase.IsValid = false; 
                responseBase.Result = result; 
                responseBase.Errors = Array.Empty<ValidationFailure>();
            });
        }

        public static TResponse Failed<TResponse>(IEnumerable<ValidationFailure> errors)
            where TResponse : IResponse<TResult>
        {
            return Activator.CreateInstance<TResponse>().Configure(response => { 
                var responseBase = response as ResponseBase<TResult>;
                responseBase.IsValid = true; 
                responseBase.Result = default; 
                responseBase.Errors = errors;
            });
        }
    }
}
