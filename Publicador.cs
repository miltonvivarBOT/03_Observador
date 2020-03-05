using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador
{
    class Publicador
    {
        List<ISuscriptor> suscriptors = null;

        public Publicador()
        {
            suscriptors = new List<ISuscriptor>();
        }
        public void RegistrarSuscriptor(ISuscriptor suscriptor) {
            if (!suscriptors.Contains(suscriptor))
            {
                suscriptors.Add(suscriptor);
            }
        }
        public void EliminarSuscriptor(ISuscriptor suscriptor) {
            if (suscriptors.Contains(suscriptor))
            {
                suscriptors.Remove(suscriptor);
            }
        }
        public void EliminarSuscriptores()
        {
            for(int i = suscriptors.Count - 1; i >= 0; i--)
            {
                suscriptors.RemoveAt(i);
            }
        }
        public void NotificarSuscriptores() {
            foreach (ISuscriptor suscriptor in suscriptors)
            {
                suscriptor.Update(this);
            }
        }
    }
}
