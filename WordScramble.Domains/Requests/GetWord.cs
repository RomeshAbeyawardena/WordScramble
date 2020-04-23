using AutoMapper;
using AutoMapper.Configuration.Conventions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Domains.ViewModels;
using GetWordResponse = WordScramble.Domains.Responses.GetWord;

namespace WordScramble.Domains.Requests
{
    [AutoMap(typeof(GetWordRequestViewModel))]
    public class GetWord : IRequest<GetWordResponse>
    {
        public int MinimumLength { get; set; }
    }
}
