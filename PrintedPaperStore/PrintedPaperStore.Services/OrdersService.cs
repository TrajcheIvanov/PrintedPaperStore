using PrintedPaperStore.Data.Interfaces;
using PrintedPaperStore.Models;
using PrintedPaperStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IBooksRepository _booksRepository;

        public OrdersService(IOrdersRepository ordersRepository, IBooksRepository booksRepository)
        {
            _ordersRepository = ordersRepository;
            _booksRepository = booksRepository;
        }
        public bool Create(Order order)
        {
            //bookservice.GetBooksByIds()

            foreach (var book in order.Books)
            {
                var bookToCheck = _booksRepository.GetById(book.BookId);

                if (bookToCheck.Quantity < 1)
                {
                    return false;
                }
                else
                {
                    bookToCheck.Quantity -= 1;
                    _booksRepository.Update(bookToCheck);
                }
            }

            order.DateCreated = DateTime.Now;
            _ordersRepository.Create(order);

            

            return true;
        }
    }
}
