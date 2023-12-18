﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public interface Profiles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }

    }
}
