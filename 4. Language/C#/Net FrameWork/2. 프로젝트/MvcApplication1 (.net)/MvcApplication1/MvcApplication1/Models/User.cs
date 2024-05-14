using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MvcApplication1.Models
{
    public class User
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserPw { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}