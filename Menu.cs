using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEnGrupo
{
    public class Menu
    {
        public void ImprimirVotos()
        {
           
        }
        private int opcion;
        public void Menuop()
        {
            do
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Menú de Votaciones");
                Console.WriteLine("------------------");
                Console.WriteLine("1.- Registrar un voto");
                Console.WriteLine("2.- Mostrar lista de estudiantes que han votado");
                Console.WriteLine("3.-Contabilizar votos");
                Console.WriteLine("4.- Salir");
                Console.WriteLine("Digite la opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Ingrese una opción válida [1-4]");
                }

            } while (opcion < 1 || opcion > 5);
        }
    }
}