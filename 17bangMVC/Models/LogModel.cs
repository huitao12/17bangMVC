using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models
{
    public class LogModel
    {
        [Required(ErrorMessage = "*用户名不能为空")]
        public string Name { get; set; }

        [MinLength(4, ErrorMessage = "*密码的长度不能小于4，大于20")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public  bool Remember { get; set; }
    }
}