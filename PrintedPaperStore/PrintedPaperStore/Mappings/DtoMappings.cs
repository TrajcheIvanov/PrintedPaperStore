﻿using PrintedPaperStore.DtoModels;
using PrintedPaperStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintedPaperStore.Mappings
{
    public static class DtoMappings
    {
        public static BookDto ToDtoModel(this Book entity)
        {
            return new BookDto
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                Description = entity.Description,
                Genre = entity.Genre,
                Price = entity.Price,
                Quantity = entity.Quantity
            };
        }

        public static Book ToDomainModel(this BookDto entity)
        {
            return new Book
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                Description = entity.Description,
                Genre = entity.Genre,
                Price = entity.Price,
                Quantity = entity.Quantity
            };
        }

        public static Order ToDomainModel(this CreateOrderDto entity)
        {
            return new Order
            {
                FullName = entity.FullName,
                Address = entity.Address,
                Phone = entity.Phone,
                Email = entity.Email,
                // this is filling the relaion table dynamically
                Books = entity.BookIds.Select(x => new BookOrder() { BookId = x }).ToList()
            };
        }
    }
}
