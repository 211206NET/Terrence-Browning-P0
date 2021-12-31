namespace Models;

public class Customer
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<Order> Orders { get; set; }
}