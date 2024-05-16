namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            double lado1 = 0;
            double lado2 = 0;
            double lado3 = 0;


            do
            {
                opcao = 0;
                lado1 = 0;
                lado2 = 0;
                lado3 = 0;


                Console.WriteLine("Digite 1 para verificar a figura: \n" +
                                  "Digite 2 para sair");
                opcao = Convert.ToInt32(Console.ReadLine());


                switch (opcao)
                {
                    case 1:


                        Console.WriteLine("\ndigite a medida do lado 1: ");
                        lado1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\ndigite a medida do lado 2: ");
                        lado2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\ndigite a medida do lado 3: ");
                        lado3 = Convert.ToDouble(Console.ReadLine());

                        
                        break;

                    case 2:
                        break;

                    default:
                        Console.WriteLine("\nErro: Opcao invalida\n");
                        break;
                }

                if(lado1 != 0 && lado2 != 0 && lado3 != 0) 
                {
                    if (lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2)
                    {

                        Console.WriteLine("\nNao e um triangulo\n");
                    }

                    else
                    {
                        if (lado1 == lado2 && lado1 == lado3)
                        {
                            Console.WriteLine("\nTriangulo equilatero\n");
                        }


                        else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
                        {
                            Console.WriteLine("\nTriangulo escaleno\n");
                        }


                        else
                        {
                            Console.WriteLine("\nTriangulo isósceles\n");
                        }
                    }
                }

                

            }
            while (opcao != 2);



            Console.WriteLine("\nObrigado por usar o verificar 2000");


        }
    }
    

}
