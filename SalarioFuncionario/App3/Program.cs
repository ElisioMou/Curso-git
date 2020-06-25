using System;
using System.Globalization;
namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num;
            Console.Write("Número do funcionário: ");
            num = int.Parse(Console.ReadLine());
            double horas;
            Console.Write("Número de horas trabalhadas: ");
            horas = double.Parse(Console.ReadLine());
            double valor;
            Console.Write("Valor por hora trabalhada: ");
            valor = double.Parse(Console.ReadLine());
           
            double salario;
            salario = horas * valor;
            Console.WriteLine("Funcionário n°:" + num);
            Console.WriteLine("Salário:R$ " + Convert.ToDecimal(salario, new CultureInfo("pt-BR")));

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("Fórmula de Báskara:");
            Console.WriteLine("a:"+ a +" b:"+ b +" c:"+ c);
            Console.WriteLine("Delta:" + delta);
            Console.WriteLine("Raízes: " + x1 + " e " + x2 + ".");

            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            int n1 = int.Parse(Console.ReadLine());
            char c1 = char.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(c1);
            Console.WriteLine(b1.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com seu nome completo: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int qrt = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double prç = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura: ");
            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
                if (num < 0)
                   Console.WriteLine("O número é negativo.", CultureInfo.InvariantCulture);
                else
                   Console.WriteLine("O número é positivo", CultureInfo.InvariantCulture);

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");


            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");

            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c)

        {
            int m;
            if (a > b && a > c) 
            {
                m = a;
            }
            else if (b > c) 
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;

            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());/
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

        int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++) {

            string[] line = Console.ReadLine().Split(' ');
            double a = double.Parse(line[0], CultureInfo.InvariantCulture);
            double b = double.Parse(line[1], CultureInfo.InvariantCulture);
            double c = double.Parse(line[2], CultureInfo.InvariantCulture);

            double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }*/

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        
        }
    }
}