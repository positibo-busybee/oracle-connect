using MediatR;
using Transco.Application.Contracts.Customers;

namespace Transco.Application.Core.Customers.Queries.GetAllCustomers
{
    public class GetAllCustomersQuery : IRequest<List<CustomerResponse>>
    {
        public GetAllCustomersQuery() { }
    }
}
