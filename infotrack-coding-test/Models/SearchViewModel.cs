using System;
using System.ComponentModel.DataAnnotations;

namespace infotrack_coding_test.Models
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "A Search Url is Required")]
        [Display(Description = "Search URL")]
        public string SearchUrl {get;set;}
        [Required(ErrorMessage = "Keywords are Required")]
        [Display(Description = "Keywords")]
        public string Keywords {get;set;}
    }
}