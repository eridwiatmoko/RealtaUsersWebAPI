﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realta.Domain.Entities
{
    public class UserPassword
    {
        [Key]
        public int UspaUserId { get; set; }
        [ForeignKey("Users")]
        public Guid UspaPasswordHash { get; set; }
        public Guid UspaPasswordSalt { get; set; }
    }
}
