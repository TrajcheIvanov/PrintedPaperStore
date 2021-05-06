using Microsoft.AspNetCore.Http;
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
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books = _booksService.GetAll();

            return Ok(books.Select(x => x.ToDtoModel()));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _booksService.GetById(id);
            return Ok(book.ToDtoModel());
        }

        [HttpPost]
        public IActionResult Create(BookDto book)
        {
            var status = _booksService.Create(book.ToDomainModel());
            if (status)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _booksService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(BookDto book)
        {
            _booksService.Update(book.ToDomainModel());
            return Ok();
        }
    }
}
