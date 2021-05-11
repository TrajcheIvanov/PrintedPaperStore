using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedPaperStore.Services.Interfaces
{
    public interface IOrdersService
    {
        void Create(Order order);
    }
}
