using PatronObservador.Fabrica;
using PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronObservador
{
    class ProcesarFabrica
    {
        public IObservadoresFactory ProcesaSuscriptor(int iOpcion)
        {
            IObservadoresFactory fabricaObservador=null;
            switch (iOpcion)
            {
                case 1:
                    fabricaObservador = new GenerarSubirCodigo();
                    break;
                case 2:
                    fabricaObservador = new GenerarNotificador();
                    break;
                case 3:
                    fabricaObservador = new GenerarCompilador();
                    break;
                case 4:
                    fabricaObservador = new GenerarEjecutorUT();
                    break;
                case 5:
                    fabricaObservador = new GenerarInstalador();
                    break;

            }
            return fabricaObservador;
        }
    }
}
