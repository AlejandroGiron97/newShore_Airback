using DomainLayer.Contracts;
using DomainLayer.Models;
using DomainLayer.Models.Third;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapper
{
    public class Flight_Transport<P, T> : IMap<P, T>
    {
        P IMap<P, T>.Map(T origin)
        {
            var transport = new Transport();

            FlightResponse flight = (FlightResponse)Convert.ChangeType(origin, typeof(FlightResponse));

            transport.FlightCarrier = flight.FlightCarrier;
            transport.FlightNumber = flight.FlightNumber;
            return (P)(object)transport;
        }
    }
}
