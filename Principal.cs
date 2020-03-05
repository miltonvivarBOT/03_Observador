using PatronObservador.Interfaces;
using PatronObservador.Observadores;
using System;

namespace PatronObservador
{
    class Principal
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Publicador publicador = new Publicador();
            ProcesarFabrica fabrica = new ProcesarFabrica();
            IObservadoresFactory procesar = null;
            Console.WriteLine("Por favor elija una opción");
            
            
            while (opcion < 7)
            {
                procesar = fabrica.ProcesaSuscriptor(1);
                publicador.RegistrarSuscriptor(procesar.GetSuscriptor());

                Console.WriteLine("1) Subir Codigo");
                Console.WriteLine("2) Agregar Notificador");
                Console.WriteLine("3) Agregar Compilador");
                Console.WriteLine("4) Agregar Ejecutor de Pruebas Unitarias");
                Console.WriteLine("5) Agregar Instalador");
                Console.WriteLine("6) Borrar Suscriptores");
                opcion = Convert.ToInt32(Console.ReadLine());
                procesar = fabrica.ProcesaSuscriptor(opcion);

                if (opcion == 1)
                {
                    publicador.NotificarSuscriptores();
                }
                else if (opcion == 6)
                {
                    publicador.EliminarSuscriptores();
                }
                else if (opcion < 7)
                { 
                    publicador.RegistrarSuscriptor(procesar.GetSuscriptor()); 
                }
                Console.WriteLine("\n\n------------------");
            }
            

            Console.ReadKey();
        }
    }
}
