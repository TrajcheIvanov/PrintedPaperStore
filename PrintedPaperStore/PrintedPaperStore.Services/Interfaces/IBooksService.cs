using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Services.Interfaces
{
    public interface IBooksService
    {
        List<Book> GetAll();
        bool Create(Book book);
        void Update(Book book);
        void Delete(int id);
        Book GetById(int id);
    }
}
