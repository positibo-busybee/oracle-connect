using Microsoft.AspNetCore.Mvc;
using Transco.Data;

namespace Transco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public CustomerController(DataContext dataContext) => this._dataContext = dataContext;


        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            return _dataContext.Customers.ToList();
        }
    }
}
