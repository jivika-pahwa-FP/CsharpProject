﻿using System;
using System.Collections.Generic;

#nullable disable

namespace practice.Models
{
    public partial class ZuserDetail
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
