using PatronObservador.Interfaces;
using PatronObservador.Observadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador.Fabrica
{
    class GenerarNotificador : IObservadoresFactory
    {
        private static Notificador singleNotificador;
        public ISuscriptor GetSuscriptor()
        {
            if (singleNotificador == null)
                singleNotificador = new Notificador();
         
            return singleNotificador;
        }
    }
}
