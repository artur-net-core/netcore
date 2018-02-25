using System;
using System.Collections.Generic;

namespace Passenger.Core.Models
{
    public class Passenger
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Node Point { get; set; }        
    }
}