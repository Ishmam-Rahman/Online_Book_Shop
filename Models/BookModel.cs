﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStroe.Models
{
    public class BookModel
    {
        [Required]
        public int Id {get; set;}
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public string Category { get; set; }
        public int BookTypeId { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        [ForeignKey("BookTypeId")]
        public BookType booktype { get; set; }
    }
}