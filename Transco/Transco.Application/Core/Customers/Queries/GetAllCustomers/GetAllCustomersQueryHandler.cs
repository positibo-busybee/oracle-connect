using MediatR;
using Microsoft.EntityFrameworkCore;
using Transco.Application.Contracts.Customers;
using Transco.Infrastructure;

namespace Transco.Application.Core.Customers.Queries.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, List<CustomerResponse>>
    {
        private readonly DataContext context;

        public GetAllCustomersQueryHandler(DataContext context) => this.context = context;

        public async Task<List<CustomerResponse>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var query = context.Customers.AsNoTracking();

            var customers = (await query.ToListAsync(cancellationToken))
                .Select(o => new CustomerResponse
                {
                    CustomerId = o.Customerid,
                    Email = o.Email,
                    FullName = $"{o.Lastname}, {o.Firstname}",
                })
                .OrderBy(o => o.FullName)
                .ToList();

            return customers;
        }
    }
}
