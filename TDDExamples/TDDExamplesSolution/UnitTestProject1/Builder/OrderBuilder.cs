using BigMart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Builder
{
    public class OrderBuilder
    {
        private Customer _customer = new CustomerBuilder().Build();
        private List<OrderLine> _lines = new List<OrderLine>();

        public Order Build()
        {
            Order order = new Order(_customer);
            foreach(var orderLine in _lines)
            {
                order.AddOrderLine(orderLine);
            }

            return order;
        }

        public OrderBuilder WithOrderLines(List<OrderLine> orderLines)
        {
            _lines = orderLines;
            return this;
        }

    }

    public class CustomerBuilder
    {
        public Customer Build()
        {
            return new Customer("Sherlock Holmes", new Address("221b Baker Street", "London",
                    new PostCode("MWX1")));
        }
    }
}
