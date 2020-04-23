using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Domains.ViewModels
{
    public class ScrambleWordRequestViewModel
    {
        [Required]
        public string Word { get; set; }
    }
}
