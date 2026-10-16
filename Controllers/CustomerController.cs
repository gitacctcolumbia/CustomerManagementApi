using Microsoft.AspNetCore.Mvc;
using CustomerManagementApi.Models;
using CustomerManagementApi.Data;

namespace CustomerManagementApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase{
    private readonly CustomerManagementContext _context;
    /*private static readonly List<Customer> customers = new List<Customer>();
    static CustomersController()
    {
        Customer customer;
        customer = new Customer
        {
        Id =       1,
        FirstName = "Marco",
        LastName  = "Rossi",
        Email     = "marco@example.com",
        Active    =  true
        };
        customers.Add(customer);

        customer = new Customer {
        Id =        2,
        FirstName = "Anna",
        LastName =  "Bianchi",
        Email =     "anna@example.com",
        Active =   true 
        };
        customers.Add(customer);

    }*/
    public CustomersController(CustomerManagementContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Customer> GetCustomers(){
        return _context.Customers.ToList();
    }
    [HttpGet("{id}")]
    public ActionResult<Customer> GetCustomer(int id)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == id);

        if (customer == null)
        {
          return NotFound();
        }

        return Ok(customer);
    }
    [HttpPost]
    public ActionResult<Customer> CreateCustomer(Customer customer)
    {
         _context.Customers.Add(customer);
         _context.SaveChanges();
         return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
    }
    [HttpPut("{id}")]
    public ActionResult<Customer> UpdateCustomer(int id, Customer customer)
    {
        var existingCustomer = _context.Customers.FirstOrDefault(c => c.Id == id);
    
        if (existingCustomer == null)
        {
          return NotFound();
        }

        if (id != customer.Id)
        {
            return BadRequest();
        }

        existingCustomer.FirstName = customer.FirstName;
        existingCustomer.LastName = customer.LastName;
        existingCustomer.Email = customer.Email;
        existingCustomer.Active = customer.Active;

        _context.SaveChanges();

        return NoContent();

    }[HttpDelete("{id}")]
    public IActionResult DeleteCustomer(int id)
    {
        var existingCustomer = _context.Customers.FirstOrDefault(c => c.Id == id);

        if (existingCustomer == null)
        {
          return NotFound();
        }

        _context.Customers.Remove(existingCustomer);
        _context.SaveChanges();

        return NoContent();

    }
}