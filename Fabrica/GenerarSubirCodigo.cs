using PatronObservador.Interfaces;
using PatronObservador.Observadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Fabrica
{
    class GenerarSubirCodigo : IObservadoresFactory
    {
        private static SubirCodigo singleSubirCodigo;
        public ISuscriptor GetSuscriptor()
        {
            if (singleSubirCodigo == null)
                singleSubirCodigo = new SubirCodigo();
            
            return singleSubirCodigo;
        }
    }
}
