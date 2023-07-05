﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Entities
{
    public class Person :BaseIdWithDates
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public virtual User user { get; set; }

    }
}
