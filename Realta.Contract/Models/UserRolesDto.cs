﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realta.Contract.Models
{
    public class UserRolesDto
    {
        [Required]
        public int UsroUserId { get; set; }
        [Required]
        public int UsroRoleId { get; set; }
    }
}
