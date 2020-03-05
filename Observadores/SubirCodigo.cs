using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Observadores
{
    class SubirCodigo : ISuscriptor
    {
        public void Update(Publicador publicador)
        {
            Console.WriteLine("Subir Codigo");
        }
    }
}
