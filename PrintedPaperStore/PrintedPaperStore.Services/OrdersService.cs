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
        private readonly IOrdersRepository ordersRepository;

        public OrdersService(IOrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }
        public void Create(Order order)
        {
            //bookservice.GetBooksByIds()
            order.DateCreated = DateTime.Now;
            ordersRepository.Create(order);
        }
    }
}
