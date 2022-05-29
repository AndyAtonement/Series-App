using System;

namespace Enterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            estacionamento.PrecoInicial = 10;
            estacionamento.PrecoPorHora = 5;
            
            string opacaoUsusario = ObterOpcaoUsuario();

            while (opacaoUsusario.ToUpper() != "X")
            {
                string veiculo = "";
                switch (opacaoUsusario)
                {
                    case "1":
                        estacionamento.AdicionarVeiculo(veiculo);
                        break;
                    case "2":
                        estacionamento.RemoverVeiculo(veiculo);
                        break;
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine("Fim do programa...");
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opacaoUsusario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Cadastrar veículo");
            Console.WriteLine("2- Remover veículo");
            Console.WriteLine("3- Listar veículo");
            Console.WriteLine("4- Limpar tela.");
            Console.WriteLine("X- Encerrar");


            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

    }
}
