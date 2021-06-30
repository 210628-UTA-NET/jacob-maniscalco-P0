using System.Collections.Generic;
public class Order {

    public List<LineItems> order {  get; set; }
    public string location { get;  set; }
    public double price { get;  set; }

     public Order()
    { }

}