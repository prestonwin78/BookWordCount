﻿using BookWordCount.Models.Database;

namespace BookWordCount.Models.Dtos
{
    public class UserBookStatsDto
    {
        public BookDto book { get; set; }
        public int? wordCount { get; set; }
        public int? pageCount { get; set; }
        public int? difficulty { get; set; }
        public int? durationInSeconds { get; set; }
    }
}