using PatronObservador.Interfaces;
using PatronObservador.Observadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Fabrica
{
    class GenerarCompilador : IObservadoresFactory
    {
        private static Compilador singleCompilador;
        public ISuscriptor GetSuscriptor()
        {
            if (singleCompilador == null)
                singleCompilador = new Compilador();
            
            return singleCompilador;
        }
    }
}
