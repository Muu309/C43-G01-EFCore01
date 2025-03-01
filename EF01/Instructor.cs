using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string? Adress { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_id { get; set; }

    }
}
