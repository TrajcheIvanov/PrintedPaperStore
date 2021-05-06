using PrintedPaperStore.Data.Interfaces;
using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintedPaperStore.Data
{
    public class BooksRepository : IBooksRepository
    {
        private readonly PrintedPaperStoreDbContext _dbContext;

        public BooksRepository(PrintedPaperStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void Delete(Book book)
        {
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _dbContext.Books.FirstOrDefault(x => x.Id == id);
        }

        public Book GetByTitle(string title)
        {
            return _dbContext.Books.FirstOrDefault(x => x.Title.ToLower() == title.ToLower());
        }

        public void Update(Book book)
        {
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }
    }
}
