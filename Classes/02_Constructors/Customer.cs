using System.Collections.Generic;

// Using overloading constructure in the below example way is a little bit ugly.
namespace CSharpIntermediate
{
  public class Customer
  {
    public int Id;
    public string Name;
    public List<Order> Orders;

    public Customer()
    {
      Orders = new List<Order>();
    }

    public Customer(int Id)
    : this()
    {
      this.Id = Id;
    }

    public Customer(int id, string name)
    : this()
    {
      this.Id = Id;
      this.Name = name;
    }
  }
}