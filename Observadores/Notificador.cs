using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Observadores
{
    class Notificador:ISuscriptor
    {
        public void Update(Publicador publicador)
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
