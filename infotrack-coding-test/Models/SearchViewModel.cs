using System;
using System.ComponentModel.DataAnnotations;

namespace infotrack_coding_test.Models
{
    public class SearchViewModel
    {
        [Required]
        public string SearchUrl {get;set;}
        [Required]
        public string Keywords {get;set;}
    }
}