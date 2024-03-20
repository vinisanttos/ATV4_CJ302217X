namespace ATV4_CJ302217X
{ 
internal class Program
{
    static void Main(string[] args)
    {
            float n1, n2, op;

            Console.WriteLine("Digite o número de n1: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de n2: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero das operaçãoes : 1 - soma, 2 - divisão, 3 - multiplicacao, 4 - subtração");
            op = float.Parse(Console.ReadLine());


            switch (op)
            {



                case 1:
                    Console.WriteLine("soma = {0}", n1 + n2);
                    break;

                case 2:
                    Console.WriteLine("divisão = {0}", n1 / n2);
                    break;

                case 3:
                    Console.WriteLine("multiplicacao = {0}", n1 * n2);
                    break;

                case 4:
                    Console.WriteLine("subtração = {0}");
                    break;


                default:
                    Console.WriteLine("opçao inválida");
                    break;

            }
        }
    }
}