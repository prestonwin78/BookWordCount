﻿using System.ComponentModel.DataAnnotations;

namespace BookWordCount.Models.Database
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        virtual public List<Book> Books { get; set; }
    }
}
