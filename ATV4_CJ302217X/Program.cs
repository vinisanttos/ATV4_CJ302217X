namespace ATV4_CJ302217X
{ 
internal class Program
{
    static void Main(string[] args)
    {
                 // Program 1 - Dia da semana por extenso
            Console.Write("Digite o número correspondente ao dia da semana (1 a 7): ");
            int numeroDia = Convert.ToInt32(Console.ReadLine());

            string diaSemana;

            switch (numeroDia)
            {
                case 1:
                    diaSemana = "Domingo";
                    break;
                case 2:
                    diaSemana = "Segunda-feira";
                    break;
                case 3:
                    diaSemana = "Terça-feira";
                    break;
                case 4:
                    diaSemana = "Quarta-feira";
                    break;
                case 5:
                    diaSemana = "Quinta-feira";
                    break;
                case 6:
                    diaSemana = "Sexta-feira";
                    break;
                case 7:
                    diaSemana = "Sábado";
                    break;
                default:
                    diaSemana = "Dia inválido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + diaSemana);


            // Program 2 - Cálculo do valor final da compra
            Console.Write("Digite o valor total da compra: ");
            double valorCompra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Formas de pagamento:");
            Console.WriteLine("1 - Dinheiro");
            Console.WriteLine("2 - PIX");
            Console.WriteLine("3 - Débito");
            Console.WriteLine("4 - Cartão de crédito");

            Console.Write("Digite o número correspondente à forma de pagamento: ");
            int formaPagamento = Convert.ToInt32(Console.ReadLine());

            double valorFinal;

            switch (formaPagamento)
            {
                case 1:
                    valorFinal = valorCompra * 0.85; // 15% de desconto à vista no dinheiro
                    break;
                case 2:
                    valorFinal = valorCompra * 0.9; // 10% de desconto à vista no PIX
                    break;
                case 3:
                    valorFinal = valorCompra * 1.05; // 5% de acréscimo no débito
                    break;
                case 4:
                    valorFinal = valorCompra * 1.1; // 10% de acréscimo no cartão de crédito
                    break;
                default:
                    valorFinal = valorCompra;
                    break;
            }

            Console.WriteLine("Valor final a ser pago: " + valorFinal);


            // Program 3 - Nome do mês por extenso e quantidade de dias
            Console.Write("Digite o número correspondente ao mês (1 a 12): ");
            int numeroMes = Convert.ToInt32(Console.ReadLine());

            string nomeMes;
            int quantidadeDias;

            switch (numeroMes)
            {
                case 1:
                    nomeMes = "Janeiro";
                    quantidadeDias = 31;
                    break;
                case 2:
                    nomeMes = "Fevereiro";
                    quantidadeDias = DateTime.IsLeapYear(DateTime.Now.Year) ? 29 : 28;
                    break;
                case 3:
                    nomeMes = "Março";
                    quantidadeDias = 31;
                    break;
                case 4:
                    nomeMes = "Abril";
                    quantidadeDias = 30;
                    break;
                case 5:
                    nomeMes = "Maio";
                    quantidadeDias = 31;
                    break;
                case 6:
                    nomeMes = "Junho";
                    quantidadeDias = 30;
                    break;
                case 7:
                    nomeMes = "Julho";
                    quantidadeDias = 31;
                    break;
                case 8:
                    nomeMes = "Agosto";
                    quantidadeDias = 31;
                    break;
                case 9:
                    nomeMes = "Setembro";
                    quantidadeDias = 30;
                    break;
                case 10:
                    nomeMes = "Outubro";
                    quantidadeDias = 31;
                    break;
                case 11:
                    nomeMes = "Novembro";
                    quantidadeDias = 30;
                    break;
                case 12:
                    nomeMes = "Dezembro";
                    quantidadeDias = 31;
                    break;
                default:
                    nomeMes = "Mês inválido";
                    quantidadeDias = 0;
                    break;
            }

            Console.WriteLine("Mês: " + nomeMes);
            Console.WriteLine("Quantidade de dias: " + quantidadeDias);


            // Program 4 - Operações matemáticas com switch
            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha a operação: +, -, *, / ou ^");
            char operacao = Convert.ToChar(Console.ReadLine());

            double resultado;

            switch (operacao)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / (double)num2;
                    break;
                case '^':
                    resultado = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    return;
            }

            Console.WriteLine("Resultado: " + resultado);


            // Program 5 - Cálculo do novo salário
            Console.Write("Digite o salário atual: ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o código do cargo: ");
            int codigoCargo = Convert.ToInt32(Console.ReadLine());

            double percentualAumento;

            switch (codigoCargo)
            {
                case 101:
                    percentualAumento = 0.075; // 7.5%
                    break;
                case 102:
                    percentualAumento = 0.097; // 9.7%
                    break;
                case 103:
                    percentualAumento = 0.117; // 11.7%
                    break;
                case 204:
                    percentualAumento = 0.089; // 8.9%
                    break;
                case 206:
                    percentualAumento = 0.1324; // 13.24%
                    break;
                case 301:
                    percentualAumento = 0.104; // 10.4%
                    break;
                case 302:
                    percentualAumento = 0.146; // 14.6%
                    break;
                default:
                    percentualAumento = 0.435; // 43.5%
                    break;
            }

            double novoSalario = salarioAtual + (salarioAtual * percentualAumento);
            double diferenca = novoSalario - salarioAtual;

            Console.WriteLine("Salário antigo: " + salarioAtual);
            Console.WriteLine("Novo salário: " + novoSalario);
            Console.WriteLine("Diferença: " + diferenca);


            // Program 6 - Cálculo do imposto de renda
            Console.Write("Digite o salário mensal: ");
            double salarioMensal = Convert.ToDouble(Console.ReadLine());

            double imposto;
            double salarioLiquido;

            if (salarioMensal <= 1903.98)
            {
                imposto = 0;
                salarioLiquido = salarioMensal;
            }
            else if (salarioMensal <= 2826.65)
            {
                imposto = salarioMensal * 0.075;
                salarioLiquido = salarioMensal - imposto;
            }
            else if (salarioMensal <= 3751.05)
            {
                imposto = salarioMensal * 0.15;
                salarioLiquido = salarioMensal - imposto;
            }
            else if (salarioMensal <= 4664.68)
            {
                imposto = salarioMensal * 0.225;
                salarioLiquido = salarioMensal - imposto;
            }
            else
            {
                imposto = salarioMensal * 0.275;
                salarioLiquido = salarioMensal - imposto;
            }

            Console.WriteLine("Imposto de renda a ser recolhido: " + imposto);
            Console.WriteLine("Salário líquido: " + salarioLiquido);
        }
    }
}
