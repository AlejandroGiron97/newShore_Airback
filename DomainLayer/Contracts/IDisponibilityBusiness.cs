using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;

namespace DomainLayer.Contracts
{
       public interface IDisponibilityBusiness
        {
            IEnumerable<Flight> GetDisponibility(Request disponibilityRequest);
        }
    
}
