﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Dtos
{
    public abstract class LinkedResourceBaseDto
    {
        public List<LinkDto> Links { get; set; }
            = new List<LinkDto>();
    }
}
