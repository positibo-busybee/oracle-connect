using MediatR;

namespace Transco.Application.Core.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public CreateCustomerCommand(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
