using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class SalesDataController : ControllerBase
    {
        private static readonly List<SalesData> salesData = new List<SalesData>();

        public SalesDataController()
        {
            salesData.Add(new SalesData()
            {
                OrderId = 150,
                Productname = "Chair",
                Amount = 10,
                Quantity = 2
            });
            salesData.Add(new SalesData()
            {
                OrderId = 151,
                Productname = "Fan",
                Amount = 20,
                Quantity = 1
            });
            salesData.Add(new SalesData()
            {
                OrderId = 152,
                Productname = "Table",
                Amount = 30,
                Quantity = 4
            });
            salesData.Add(new SalesData()
            {
                OrderId = 153,
                Productname = "Dresser",
                Amount = 40,
                Quantity = 3
            });
            salesData.Add(new SalesData()
            {
                OrderId = 154,
                Productname = "Laptop",
                Amount = 50,
                Quantity = 5
            });
        }

        [HttpGet]
        public IEnumerable<SalesData> Get()
        {
            return salesData;
        }
        [HttpGet("{id}", Name = "Get")]
            public SalesData GetSalesById(int id)
        {
            return salesData.Find(x => x.OrderId == id);
        }
    }
    }
