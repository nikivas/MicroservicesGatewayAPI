using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroservicesGatewayAPI
{
    public class Route
    {
        public string Endpoint { get; set; }
        public Destination Destination { get; set; }
    }
}
