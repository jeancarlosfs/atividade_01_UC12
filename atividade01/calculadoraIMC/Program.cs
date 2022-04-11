using System;

namespace calculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float pessoaAltura;
            float pessoaPeso;
            float resultado;
            string opcao; 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
=============================================================
|            BEM-VINDO AO SISTEMA DE CALCULO DE IMC         |
=============================================================


");
            do
            {
                  Console.WriteLine(@$"
=============================================================
|                                                           |
|                1 - Calcular IMC                           |
|                                                           |
|                0 - Sair                                   |
|                                                           |
=============================================================
");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"\nDigite sua altura: \n");
            
                        pessoaAltura = float.Parse(Console.ReadLine());
                        
                        Console.WriteLine($"\nDigite seu peso: \n");
                        
                        pessoaPeso = float.Parse(Console.ReadLine());
                        
                        resultado = pessoaPeso / (pessoaAltura*pessoaAltura);

                        Console.WriteLine($"Resultado: { resultado }\n");

                        if (resultado < 18.5)
                        {
                            Console.WriteLine($"Abaixo do peso \n");
                        }else if(resultado >= 18.5 & resultado <= 24.9){
                            Console.WriteLine($"Peso Normal \n");
                        }else if(resultado >= 25 & resultado <= 29.9){
                            Console.WriteLine($"Sobrepeso\n");
                        }else if(resultado >= 30 & resultado <= 34.9){
                            Console.WriteLine($"Obesidade Grau I \n");
                        }else if(resultado >= 35 & resultado <= 39.9){
                            Console.WriteLine($"Obesidade Grau II \n");
                        }
                        else
                        {
                             Console.WriteLine($"Obesidade Grau III \n");
                        }
                        break;
                    case "0":
                        Console.WriteLine($"Obrigado por usar nosso sistema!");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, digite uma opção válida");
                        break;
                }
                                 
            } while (opcao != "0");
            
                     
            
        }
    }
}
