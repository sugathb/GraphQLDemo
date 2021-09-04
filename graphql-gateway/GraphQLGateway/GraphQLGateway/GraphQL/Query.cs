using System.Collections.Generic;
using GraphQLGateway.Models;

namespace GraphQLGateway.GraphQL
{
    public class Query
    {
        public IEnumerable<Order> GetOrder()
        {
            return new List<Order>()
            {
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    TotalPrice = 10
                },
                new Order
                {
                    Id = 2,
                    CustomerId = 2,
                    TotalPrice = 20
                },
                new Order
                {
                    Id = 3,
                    CustomerId = 3,
                    TotalPrice = 30
                }
            };
        }
        public IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>()
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Ford",
                    Address = "Address 1",
                    Email = "test1@testmail.com",
                    Mobile = "0449111111"
                },
                new Customer
                {
                    Id = 1,
                    FirstName = "Angus",
                    LastName = "Bowmen",
                    Address = "Address 2",
                    Email = "test2@testmail.com",
                    Mobile = "0449111112"
                },
                new Customer
                {
                    Id = 1,
                    FirstName = "Mark",
                    LastName = "Cater",
                    Address = "Address 3",
                    Email = "test3@testmail.com",
                    Mobile = "0449111113"
                }
            };
        }
    }
}
