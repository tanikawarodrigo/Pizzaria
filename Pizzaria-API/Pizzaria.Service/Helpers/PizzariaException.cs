using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Service.Helpers
{
    public class PizzariaException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public PizzariaException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
