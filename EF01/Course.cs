﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class Course
    {
        public int Id { get; set; }
        public decimal Duration { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Top_id { get; set; }

    }
}
