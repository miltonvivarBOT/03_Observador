using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Interfaces
{
    interface ISuscriptor
    {
        void Update(Publicador publicador);
    }
}
