using MediatR;
using Microsoft.EntityFrameworkCore;
using Transco.Application.Contracts.Customers;
using Transco.Infrastructure;

namespace Transco.Application.Core.Customers.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerResponse>
    {
        private readonly DataContext context;

        public GetCustomerByIdQueryHandler(DataContext context) => this.context = context;

        public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await context.Customers
                .Select(o => new CustomerResponse
                {
                    CustomerId = o.Customerid,
                    Email = o.Email,
                    FullName = $"{o.Lastname}, {o.Firstname}",
                })
                .FirstOrDefaultAsync(o => o.CustomerId == request.CustomerId);

            return customer;
        }
    }
}
