namespace Transco.Domain;

public partial class Customer
{
    public int Customerid { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;
}
