using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController1 : Controller
    {
        // Action Method Model Binding
        // Model Binding - Getting data from Request
        //Route Date =>BaseUrl/Products/C/A/{Value}
        //Query String => BaseUrl/C/A?id=Value
        // HTML From
        // Request Body => JSON, XML, Text
        // Headers => [FromHeader ]
        public string Get(/* [FromHeader */ int id)
        {
            return $"Product ID: {id}"; 
        }
        //public string Create(int id, string name, Product product)
        //{
        //    return $"Product With Id: {id} :: Name {name}\n{product.Id} :: {product.Name}";
        //}

        public string Create([FromQuery]int id, [FromQuery] string name, [FromForm]Product product)
        {
            return $"Product With Id: {id} :: Name {name}\n{product.Id} :: {product.Name}";
        }
    }
}
