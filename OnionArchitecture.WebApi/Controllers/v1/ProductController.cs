using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Products.Commands.CreateProduct;
using OnionArchitecture.Application.Features.Products.Commands.DeleteProductById;
using OnionArchitecture.Application.Features.Products.Commands.UpdateProduct;
using OnionArchitecture.Application.Features.Products.Queries.GetAllProducts;
using OnionArchitecture.Application.Features.Products.Queries.GetProductById;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.WebApi.Controllers.v1
{
    //[Route("api/[controller]")]
    //[ApiController]
    [ApiVersion("1.0")]
    public class ProductController : BaseApiController
    {
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductsParameter filter)
        {

            return Ok(await Mediator.Send(new GetAllProductsQuery() { PageSize = filter.PageSize, PageNumber = filter.PageNumber }));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetProductByIdQuery { Id = id }));
        }

        // POST api/<controller>
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteProductByIdCommand { Id = id }));
        }
    }
}
