using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScramble.Domains.ViewModels
{
    public class LookupIndexViewModel
    {
        public string Word { get; set; }
        public string DictionaryUriFormat { get; set; }
        public string ModalContainer { get; set; }
    }
}
