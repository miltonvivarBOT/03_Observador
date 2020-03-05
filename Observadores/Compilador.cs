using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Observadores
{
    class Compilador : ISuscriptor
    {
        public void Update(Publicador publicador)
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}
