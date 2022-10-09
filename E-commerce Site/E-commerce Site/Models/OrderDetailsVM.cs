using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_Site.Models
{
    public class OrderDetailsVM
    {
     public OrderHeader OrderHeader{ get; set; } 
     public IEnumerable<OrderDetails> OrderDetails { get; set; }
     
    }}