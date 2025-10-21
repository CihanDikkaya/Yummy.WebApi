using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Api.Context;
using Yummy.Api.Entity;

namespace Yummy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IValidator<Product> _validator;
        private readonly ApiContext _context;

        public ProductController(IValidator<Product> validator, ApiContext context)
        {
            _validator = validator;
            _context = context;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var valu = _context.Products.ToList();
            return Ok(valu);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            }

            else
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return Ok("Ürün Ekleme Başarılı");
            }
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return Ok("Silme İşlemi Başarılı");
        }

    }
}
