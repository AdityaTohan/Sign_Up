﻿using System;
using System.Collections.Generic;

namespace UserD.Models
{
    public partial class UserDetail
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
