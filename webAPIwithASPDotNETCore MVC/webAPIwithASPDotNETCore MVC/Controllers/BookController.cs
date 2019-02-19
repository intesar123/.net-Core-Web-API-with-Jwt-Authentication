using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webAPIwithASPDotNETCore_MVC.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAPIwithASPDotNETCore_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        // GET: api/<controller>
        private readonly BookContext _bookContext;
        public BookController(BookContext context)
        {
            _bookContext = context;
            if (_bookContext.Books.Count() == 0)
            {
                _bookContext.Books.Add(new Book { Id = "A1", BookName = "Wings of fire", Author = "APJ Abdul Kalam", Category = "Biography", Price = 500 });
                _bookContext.SaveChanges();
            }
        }
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public ActionResult Get()
        {
            var user = HttpContext.User;
            if(user.HasClaim(c=>c.Type=="Full Name"))
            {
                string Name = user.Claims.FirstOrDefault(c => c.Type == "Full Name").Value;
            }
            List<Book> lstBook = _bookContext.Books.ToList();
            return Json(lstBook);
        }


    }
}
