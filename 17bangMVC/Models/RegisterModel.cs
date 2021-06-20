using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17bangMVC.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "*用户名不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*密码不能为空")]
        [MinLength(4, ErrorMessage = "*密码的长度不能小于4，大于20")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "*邀请人不能为空")]
        public string InvitedByUserName { get; set; }

        [StringLength(4, MinimumLength = 4, ErrorMessage = "*邀请码只能是4位数字")]
        [Required(ErrorMessage = "*邀请码不能为空")]
        public string InviteByCode { get; set; }

        [StringLength(25, ErrorMessage = "* 确认密码的长度不能小于4,大于20", MinimumLength = 1)]
        [Required(ErrorMessage = "* 确认密码不能为空")]
        public string ComfirmPassword { get; set; }
    }
}
