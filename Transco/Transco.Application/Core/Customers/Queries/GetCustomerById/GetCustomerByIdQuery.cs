using MediatR;
using Transco.Application.Contracts.Customers;

namespace Transco.Application.Core.Customers.Queries.GetCustomerById
{
    public class GetCustomerByIdQuery : IRequest<CustomerResponse>
    {
        public int CustomerId { get; set; }

        public GetCustomerByIdQuery(int customerId) => this.CustomerId = customerId;
    }
}
