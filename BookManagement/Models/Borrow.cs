using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookManagement.Models
{
    public class Borrow
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int PersonID { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
        public bool Subscribe { get; set; }
        public string SubscribeDate { get; set; }
        public Book Book = new Book();
        public Person Person = new Person();
    }
    public class BorrowDBContext:DbContext
    {
        public BorrowDBContext()
        {

        }
        public DbSet<Borrow> Borrow { get; set; }
    }

}