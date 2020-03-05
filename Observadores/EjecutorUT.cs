using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Observadores
{
    class EjecutorUT : ISuscriptor
    {
        public void Update(Publicador publicador)
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
