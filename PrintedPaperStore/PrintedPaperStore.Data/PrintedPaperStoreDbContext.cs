using Microsoft.EntityFrameworkCore;
using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Data
{
    public class PrintedPaperStoreDbContext : DbContext
    {
        public PrintedPaperStoreDbContext(DbContextOptions<PrintedPaperStoreDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookOrder> BookOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
