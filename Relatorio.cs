using System;

namespace Aula10PolimorfismoOverride
{
    public class Relatorio
    {
        public DateTime data;

        public virtual void MostrarRelatorio(){

            System.Console.WriteLine("Mostrando relatório geral: ");

        }

    }
}