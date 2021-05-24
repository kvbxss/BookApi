﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Models
{
    public class Book
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description {get; set;}

        internal bool Any()
        {
            throw new NotImplementedException();
        }
      
    }
}
