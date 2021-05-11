using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Data.Interfaces
{
    public interface IOrdersRepository
    {
        void Create(Order order);
    }
}
