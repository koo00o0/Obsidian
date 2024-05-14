using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MvcApplication1.Models
{
    public class TodoList
    {
        [Required]
        public string Context { get; set; }


        [Required]
        public string id { get; set; }

    }
}