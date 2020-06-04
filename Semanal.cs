namespace Aula10PolimorfismoOverride
{
    public class Semanal : Relatorio
    {
        public override void MostrarRelatorio(){

            base.MostrarRelatorio();
            System.Console.WriteLine("Mostrando relatório por semana: ");
            System.Console.WriteLine("----------------------------");

        }
    }
}