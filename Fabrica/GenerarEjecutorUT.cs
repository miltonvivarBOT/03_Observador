using PatronObservador.Interfaces;
using PatronObservador.Observadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Fabrica
{
    class GenerarEjecutorUT : IObservadoresFactory
    {
        private static EjecutorUT singleEjecutorUT;
        public ISuscriptor GetSuscriptor()
        {
            if (singleEjecutorUT == null)
                singleEjecutorUT = new EjecutorUT();
         
            return singleEjecutorUT;
        }
    }
}
