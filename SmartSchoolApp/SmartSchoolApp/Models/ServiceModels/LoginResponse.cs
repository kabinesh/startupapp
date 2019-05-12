using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchoolApp.Models.ServiceModels
{
    public class LoginResponse
    {
        public string Status { get; set; }

        public User UserDetails { get; set; }

        public string Message { get; set; }
    }
}
