using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class NewTaskViewModel
    {
        [Required(ErrorMessage ="Zadnaie musi posiadać tytuł!!!")]
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
