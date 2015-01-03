using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.DataObjects
{
    public class AccountObject
    {
        public string Account { get; set; }

        public string Password { get; set; }
    }
    public class LoginObject
    {
        [Required]
        [Display(Name = "用户名")]
        public string Account { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Display(Name = "记住我?")]
        public bool RememberMe { get; set; }
    }
}
