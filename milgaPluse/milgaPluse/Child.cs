﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milgaPluse
{
    class Child
    {
        public int id { get; set; }
        public DateTime birthDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int parentId { get; set; }
        public bool married { get; set; }
    }
}
