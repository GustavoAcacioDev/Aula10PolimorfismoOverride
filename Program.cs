using System;

namespace Aula10PolimorfismoOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensal mensal = new Mensal();

            mensal.MostrarRelatorio();
            

            Anual anual = new Anual();

            anual.MostrarRelatorio();

        }
    }
}
