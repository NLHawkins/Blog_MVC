﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog_MVC.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [DisplayName("Post Title")]
        public string Title { get; set; }

        public string SampleText { get; set; }

        [DisplayName("What is your name?")]
        public string Author { get; set; }

        public DateTime Created { get; set; }

        [DisplayName("Write your Post")]
        public string Body { get; set; }
    }

    public class BPContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }

    }
}