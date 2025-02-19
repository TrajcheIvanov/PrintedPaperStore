﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrintedPaperStore.DtoModels;
using PrintedPaperStore.Mappings;
using PrintedPaperStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintedPaperStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }


        /// <summary>
        /// Creates new order from given data
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(CreateOrderDto createOrderDto)
        {
            if (createOrderDto.BookIds.Count == 0)
            {
                return BadRequest(ModelState);
            }


            if (ModelState.IsValid)
            {
                var response = _ordersService.Create(createOrderDto.ToDomainModel());
                if (!response)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    return Ok();
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
            
        }
    }
}
