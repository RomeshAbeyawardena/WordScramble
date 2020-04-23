using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Domains.ViewModels;
using ScrambleWordResponse = WordScramble.Domains.Responses.ScrambleWord;

namespace WordScramble.Domains.Requests
{
    [AutoMap(typeof(ScrambleWordRequestViewModel))]
    public class ScrambleWord : IRequest<ScrambleWordResponse>
    {
        public string Word { get; set; }
    }
}
