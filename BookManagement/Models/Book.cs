﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookManagement.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }   //出版社
        public string Summary { get; set; }   //简介
        public string Language { get; set; }
        public bool Situation { get; set; }  //True 代表可借（未被借走），False代表不可借（已被借走）
        public Person Person { get; set; }
    }
    public class BooksDBContext : DbContext
    {
        public BooksDBContext()
        {
            
        }
        public DbSet<Book> Books { get; set; }
    }
}