using MediatR;
using Transco.Infrastructure;

namespace Transco.Application.Core.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly DataContext context;

        public CreateCustomerCommandHandler(DataContext context) => this.context = context;

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            context.Customers.Add(new Domain.Customer
            {
                Firstname = request.FirstName,
                Lastname = request.LastName,
                Email = request.Email,
            });

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }   
    }
}
