using Microsoft.AspNetCore.Mvc;
using System;

namespace Attributes.Controllers
{
    [Route("Info")]
    public class InfoController : Controller
    {
        [Route("{name:minlength(3)}/{age:int}")]
        public IActionResult Person(string name, int age)
        {
            return Content($"Name: {name}, Age: {age}");
        }

        [Route("act/rout/{id=223}")]
        public string Act(int? id)
        {
            return $"Id = {id}";
        }
    }
}
