using MediatR;
using Microsoft.AspNetCore.Mvc;
using Transco.Application.Core.Customers.Queries.GetAllCustomers;
using Transco.Application.Core.Customers.Queries.GetCustomerById;

namespace Transco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator mediator;
        public CustomerController(IMediator mediator) => this.mediator = mediator;


        [HttpGet(Name = "GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var result = await mediator.Send(new GetAllCustomersQuery());

            return Ok(result);
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetCustomerById(int customerId)
        {
            var result = await mediator.Send(new GetCustomerByIdQuery(customerId));

            return Ok(result);
        }
    }
}
