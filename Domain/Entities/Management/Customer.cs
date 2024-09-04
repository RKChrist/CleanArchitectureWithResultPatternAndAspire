using Domain.ValueObjects.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Management
{
    public class Customer
    {
        public CustomerId Id { get; set; } = Guid.NewGuid();

    }
}
