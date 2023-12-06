using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("S - Encerrar o programa");
                Console.Write("Opção escolhida: ");

                string opcao = Console.ReadLine().ToUpper();
                if (opcao == "S")
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite a temperatura em graus Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit:F2}");
                        break;
                    case "2":
                        Console.Write("Digite a temperatura em graus Fahrenheit: ");
                        double fahrenheit2 = double.Parse(Console.ReadLine());
                        double celsius2 = (fahrenheit2 - 32) * 5 / 9;
                        Console.WriteLine($"Temperatura em Celsius: {celsius2:F2}");
                        break;
                    case "3":
                        Console.Write("Digite a altura em metros: ");
                        double alturaH = double.Parse(Console.ReadLine());
                        double pesoIdealH = 72.7 * alturaH - 58;
                        Console.WriteLine($"Peso ideal: {pesoIdealH:F2} kg");
                        Console.Write("Digite o peso atual em kg: ");
                        double pesoAtualH = double.Parse(Console.ReadLine());
                        if (pesoAtualH > pesoIdealH)
                        {
                            Console.WriteLine("Acima do peso ideal");
                        }
                        else if (pesoAtualH < pesoIdealH)
                        {
                            Console.WriteLine("Abaixo do peso ideal");
                        }
                        else
                        {
                            Console.WriteLine("Peso ideal");
                        }
                        break;
                    case "4":
                        Console.Write("Digite a altura em metros: ");
                        double alturaM = double.Parse(Console.ReadLine());
                        double pesoIdealM = 62.1 * alturaM - 44.7;
                        Console.WriteLine($"Peso ideal: {pesoIdealM:F2} kg");
                        Console.Write("Digite o peso atual em kg: ");
                        double pesoAtualM = double.Parse(Console.ReadLine());
                        if (pesoAtualM > pesoIdealM)
                        {
                            Console.WriteLine("Acima do peso ideal");
                        }
                        else if (pesoAtualM < pesoIdealM)
                        {
                            Console.WriteLine("Abaixo do peso ideal");
                        }
                        else
                        {
                            Console.WriteLine("Peso ideal");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
    }
}
}

