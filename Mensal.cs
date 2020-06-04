namespace Aula10PolimorfismoOverride
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){

            base.MostrarRelatorio();
            System.Console.WriteLine("Mostrando relatório por mês: ");
            System.Console.WriteLine("----------------------------");

        }
    }
}