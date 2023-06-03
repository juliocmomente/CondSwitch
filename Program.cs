internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Switch!");

        System.Console.WriteLine("1 variável");
        AvaliarMedida(-5.5);
        AvaliarMedida(132.0);
        AvaliarMedida(double.NaN);
        AvaliarMedida(75.9);
        void AvaliarMedida(double medida)
        {
            switch (medida)
            {
                case < 0.0:
                    System.Console.WriteLine($"O valor da medida é {medida}. Abaixo do permitido.");
                    break;
                case > 100.00:
                    System.Console.WriteLine($"O valor da medida é {medida}. Acima do permitido.");
                    break;
                case double.NaN:
                    System.Console.WriteLine("Falha na medida.");
                    break;
                default:
                    System.Console.WriteLine($"A medida é {medida}.");
                    break;
            }
        }

        System.Console.WriteLine("Switch com duas variável e protetor de maiúsculas e minúsculas");
        AvaliarMedidas(3, 4);
        AvaliarMedidas(9, 9);
        AvaliarMedidas(2, -1);
        void AvaliarMedidas(int medida1, int medida2)
        {
            switch ((medida1, medida2))
            {
                case ( > 0, > 0) when medida1 == medida2:
                    System.Console.WriteLine($"Ambas as medidas são válidas e iguais a {medida1}");
                    break;
                case ( > 0, > 0):
                    System.Console.WriteLine($"Primeira medida = {medida1}, Segunda medida = {medida2}");
                    break;
                default:
                    System.Console.WriteLine("Ao menos uma das medidas é inválida");
                    break;
            }
        }


    }
}