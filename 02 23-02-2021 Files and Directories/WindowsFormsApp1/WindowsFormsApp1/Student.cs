﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Grade}";
        }
    }
}
