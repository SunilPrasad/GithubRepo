using System;
using BigMart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Builder;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void ChargesCustomerForTotalCostOfAllOrderedItems()
        {
            Order order = new Order(
                new Customer("Sherlock Holmes",
                    new Address("221b Baker Street", "London",
                    new PostCode("MWX1"))));
            order.AddOrderLine(new OrderLine("Deerstalker Hat", 1));
            order.AddOrderLine(new OrderLine("Tweed Cape", 1));

            Order order1 = new OrderBuilder().Build();

            /*
             new OrderBuilder()
                    .fromCustomer(
                        new CustomerBuilder()
                            .withAddress(new AddressBuilder().withNoPostcode().build())
                            .build())
                            .build();
             
             */
        }

    }
}

