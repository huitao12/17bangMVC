﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Article : BaseEntity
    {
        public User Author { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }

    }
}
