using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADAuthenticaionAPI.Data.DTOs
{
    public class UserForReturnDto
    {
        public string Username { get; set; }
        public bool IsValidated { get; set; }
    }
}
