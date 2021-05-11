using PrintedPaperStore.Data.Interfaces;
using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Data
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly PrintedPaperStoreDbContext _context;

        public OrdersRepository(PrintedPaperStoreDbContext context)
        {
            _context = context;
        }
        public void Create(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
