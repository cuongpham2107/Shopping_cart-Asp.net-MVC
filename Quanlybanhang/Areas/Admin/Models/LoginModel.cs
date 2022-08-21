﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Quanlybanhang.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Bạn chưa điền tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bạn chưa điền tên mật khẩu")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}