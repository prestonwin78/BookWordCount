﻿using AutoMapper;
using BookWordCount.Models.Database;
using BookWordCount.Models.Dtos;

namespace BookWordCount.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<BookDto, Book>().ReverseMap();
        }
    }
}