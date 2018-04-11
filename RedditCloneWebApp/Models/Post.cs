﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditCloneWebApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int Votes { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}