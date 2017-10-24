using System;
using Microsoft.AspNetCore.Mvc;
using SampleClassLibrary;

namespace WebApiCosturaNSwag
{
    public class SampleController : ControllerBase
    {
        [HttpGet, Route("foo")]
        public Foo GetFoo()
        {
            return new Foo { Bar = 2 };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
