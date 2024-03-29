﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores_API.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsReal { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //navigation Properties
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<Book_Author> Book_Authors { get; set; }

    }
}
