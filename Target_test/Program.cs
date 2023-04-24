using System;
class Program
{
    static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex05();
    }

    static void Ex01()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K++;
            SOMA += K;
        }

        Console.WriteLine("SOMA = " +SOMA+"\n");

    }

    static void Ex02()
    {
        int entrada;
        Console.WriteLine("Informe o número de entrada: ");
        entrada = Convert.ToInt32(Console.ReadLine());

        bool isFib = true;

        int lastNum = 0, currentNum = 1, calc = 0;

        for (int fibonacci = 0; fibonacci <= entrada; fibonacci = currentNum)
        {
            //Console.Write(fibonacci + " ");
            calc = lastNum + currentNum;
            lastNum = currentNum;
            currentNum = calc;

            if(fibonacci != entrada)
            {
                isFib = false;
            }
            else
            {
                isFib = true; break;
            }
        }
        
        if(isFib)
        {
            Console.WriteLine("O Número " + entrada + " faz parte da sequência fibonacci\n");
        }
        else
        {
            Console.WriteLine("O Número " + entrada + " NÃO faz parte da sequência fibonacci\n");
        }

    }

    static void Ex03()
    {
        /*
         * a) 1, 3, 5, 7, ___ 9

           b) 2, 4, 8, 16, 32, 64, ____ 128

           c) 0, 1, 4, 9, 16, 25, 36, ____ 49

           d) 4, 16, 36, 64, ____ 100

           e) 1, 1, 2, 3, 5, 8, ____ 13

           f) 2,10, 12, 16, 17, 18, 19, ____ 200

         */
    }

    static void Ex04()
    {
        /*
            Primeiro calcular o tempo para o encontro
            
            Velocidade = distancia/tempo
            tempo = distancia/velocidade
            tempo = 100/(110+80)
            tempo = 100/190
            tempo = por volta de 0.52h, ou mais ou menos 32min

            Agora calcular a distância que cada um percorreu

            carro:
                distancia = tempo * velocidade
                distancia = 0.52 * 110
                distancia = 57.2

            caminhão:
                distancia = 0.52 * 80
                distancia = 41.6

            Ou seja, em 32 min o caminhão ainda não terá chegado na metade do caminho, enquanto o carro já terá passado por volta de 7.2km.
            O que faz com que o carro esteja mais próximo de Ribeirão Preto. Os pedágios auxiliam nesse resultado.
         */
    }

    static void Ex05()
    {
        string entrada = "";
        Console.WriteLine("Escreva sua string: ");
        entrada = Console.ReadLine();
        string rever = "";

        for(int i = entrada.Length-1; i >= 0; i--)
        {
            rever += entrada[i];
        }

        Console.WriteLine("Reverso de " + entrada + " é " + rever);
    }
}
