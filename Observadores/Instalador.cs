using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Observadores
{
    class Instalador : ISuscriptor
    {
        public void Update(Publicador publicador)
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
