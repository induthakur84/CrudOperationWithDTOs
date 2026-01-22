using CrudOperationWithDTOs.DTOs;
using CrudOperationWithDTOs.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperationWithDTOs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        //Command and query architecture-> CQA
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<ProductReadAndUpdateDto>>> GetAll()
        {

            ///Getall commnad
            var products = await _productService.GetAll();
            return Ok(products);
        }
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<ProductReadAndUpdateDto>> GetById(int id)
        {
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<ProductReadAndUpdateDto>> Create(ProductCreateDto productCreateDto)
        {
            var createdProduct = await _productService.Create(productCreateDto);
            return CreatedAtAction(nameof(GetById), new { id = createdProduct.Id }, createdProduct);
        }
        [HttpPut("Update")]
        public async Task<ActionResult<ProductReadAndUpdateDto>> Update( ProductReadAndUpdateDto productReadAndUpdateDto)
        {
            var updatedProduct = await _productService.Update(productReadAndUpdateDto);
            if (updatedProduct == null)
            {
                return NotFound();
            }
            return Ok(updatedProduct);
        }

    }
}




//apo/getbyid/3

//api/getbyuser/user: ram/password:1234




//api/create



// api versioning-> we can version our api with the help of url or header
// what is system versioning
//how to map relations in entity framework  




