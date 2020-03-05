using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Interfaces
{
    interface IObservadoresFactory
    {
        ISuscriptor GetSuscriptor();
    }
}
