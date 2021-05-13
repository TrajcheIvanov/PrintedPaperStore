using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Services.Interfaces
{
    public interface IOrdersService
    {
        /// <summary>
        /// Creates new order
        /// </summary>
        /// <param name="order"></param>
        bool Create(Order order);
    }
}
