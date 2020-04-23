using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Domains.ViewModels
{
    public class SolveWordRequestViewModel
    {
        [Required]
        public string OriginalWord { get; set; }

        [Required]
        public string Answer { get; set; } 
    }
}
