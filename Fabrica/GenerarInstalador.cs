using PatronObservador.Interfaces;
using PatronObservador.Observadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Fabrica
{
    class GenerarInstalador : IObservadoresFactory
    {
        private static Instalador singleInstalador;
        public ISuscriptor GetSuscriptor()
        {
            if (singleInstalador == null)
                singleInstalador = new Instalador();

            return singleInstalador;
        }
    }
}
