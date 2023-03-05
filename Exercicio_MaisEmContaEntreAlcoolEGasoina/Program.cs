internal class Program
{
    private static void Main(string[] args)
    {
        double preco_alcool, preco_gas;

        Console.WriteLine("Digite o preco alcool: ");
        preco_alcool = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o preco gasolina: ");
        preco_gas = double.Parse(Console.ReadLine());


        if (preco_alcool / preco_gas <= 0.72)
        {
            Console.WriteLine("compre gasolina");
        }
        else
        {
            Console.WriteLine("compre alcool");
        }
    }
}