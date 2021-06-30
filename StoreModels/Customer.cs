using System.Collections.Generic;
public class Customer 
{
    public string name { get; set; }
    public string address { get; set; }
    public string phoneNumber { get; set; }
    public List<Order> orders { get; set; }


    public Customer()
    { }
}