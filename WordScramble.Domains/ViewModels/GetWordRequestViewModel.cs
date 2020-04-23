using AutoMapper;
using AutoMapper.Configuration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScramble.Domains.Requests;

namespace WordScramble.Domains.ViewModels
{
    public class GetWordRequestViewModel
    {
        public int MinimumLength { get; set; }
    }
}
