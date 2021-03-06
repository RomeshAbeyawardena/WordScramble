﻿using FluentValidation.Results;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WordScramble.Contracts;
using WordScramble.Domains;

namespace WordScramble.Services
{
    public abstract class ResultRequestHandlerBase<TRequest, TResponse, TResult> : IRequestHandler<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : IResponse<TResult>
    {
        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);

        protected TResponse Success(TResult result)
        {
            return ResponseBase<TResult>.Success<TResponse>(result);
        }

        protected Task<TResponse> SuccessAsync(TResult result)
        {
            return Task.FromResult(Success(result));
        }

        protected TResponse Failed(IEnumerable<ValidationFailure> errors)
        {
            return ResponseBase<TResult>.Failed<TResponse>(errors);
        }
    }
}
