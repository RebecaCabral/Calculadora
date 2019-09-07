using System;
using System.Collections.Generic;

namespace projeto
{
    class Program
    {
        public static void DesejaContinuar(Calculadora calcular)
        {
            string continuar;

            Console.WriteLine("Deseja fazer outra operação? S/N");
            continuar = Console.ReadLine();
            if (continuar == "S" || continuar == "SIM")
            {
                loop(calcular);
            }
            else
            {
                if (continuar == "N" || continuar == "Não")
                {
                    Console.WriteLine("Obrigado! ");
                    Console.ReadLine();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não foi possivel entender o comando!");

                    Console.BackgroundColor = ConsoleColor.Black;
                    DesejaContinuar(calcular);
                }
            }

        }

        public static void loop(Calculadora calcular)
        {
            int A, B, SOMA, dia, multiplicarAB;
            string continuar, operacao;

            Console.WriteLine("Escolha a operação 1 para SOMAR, 2 para MULTIPLICAR e 3 para Listar as ultimas operações: ");
            operacao = Console.ReadLine();

            if (operacao == "3" || operacao == "Listar")
            {
                for (int i = 0; i < calcular.Mensagens.Count; i++)
                {
                    Console.WriteLine(calcular.Mensagens[i]);
                }
            }

            if (operacao == "1" || operacao == "Somar")
            {
                Console.WriteLine("Entra com um numero: ");
                A = int.Parse(Console.ReadLine());

                Console.WriteLine("Entra com um numero: ");
                B = int.Parse(Console.ReadLine());

                SOMA = calcular.Somar(A, B);
                Console.WriteLine("Resultado da soma é: " + SOMA);
            }

            if (operacao == "2" || operacao == "Multiplicar")
            {
                Console.WriteLine("Entra com um numero: ");
                A = int.Parse(Console.ReadLine());

                Console.WriteLine("Entra com um numero: ");
                B = int.Parse(Console.ReadLine());

                multiplicarAB = calcular.multiplicar(A, B);
                Console.WriteLine("Resultado da Multiplicação é: " + multiplicarAB);
            }
            
            DesejaContinuar(calcular);
        }

        static void Main(string[] args)
        {
            Calculadora calcular = new Calculadora();
            loop(calcular);


            //// SOMA = calcular.Somar(A, B);
            // Console.WriteLine("Resultado da soma é: " + SOMA);


            // multiplicarAB = calcular.multiplicar(A, B);
            // Console.WriteLine("Resultado da multiplicação é: " + multiplicarAB);

            // int dividirAB;
            // dividirAB = calcular.dividir(A, B);
            // Console.WriteLine("Resultado da divisão é:  " + dividirAB);

            // int diminuirAB;
            // diminuirAB = calcular.subtrair(A, B);
            // Console.WriteLine("Resultado da subtração é:  " + diminuirAB);

            // int RestoDaDivisaoAB;
            // RestoDaDivisaoAB = calcular.Resto(A, B);
            // Console.WriteLine("Resultado da resto é:  " + RestoDaDivisaoAB);


            // int CuboCalculado;
            // CuboCalculado = calcular.CalcularCubo(A);
            // Console.WriteLine("O calculo do cubo A é: " + CuboCalculado);

            // CuboCalculado = calcular.CalcularCubo(B);
            // Console.WriteLine("O calculo do cubo B é: " + CuboCalculado);

            // int SomarDiaComAB;
            // dia = DateTime.Now.Day;
            // SomarDiaComAB = calcular.SomarDiaHoje(A, dia);
            // Console.WriteLine("O calculo do SomarDiaHoje A é: " + SomarDiaComAB);

            // SomarDiaComAB = calcular.SomarDiaHoje(B, dia);
            // Console.WriteLine("O calculo do SomarDiaHoje B é: " + SomarDiaComAB);
        }
    }
    public class Calculadora
    {
        public int Somar(int A, int B)
        {
            int somaAB;
            somaAB = A + B;

            Mensagens.Add("Soma de: " + A + " " + B + " é igual: " + somaAB);

            return somaAB;
        }

        public int multiplicar(int A, int B)
        {
            int multiplicarAB;
            multiplicarAB = A * B;
            Mensagens.Add("Multiplicação de: " + A + " " + B + " é igual: " + multiplicarAB);
            return multiplicarAB;
        }

        public int dividir(int A, int B)
        {
            int dividirAB;
            dividirAB = A / B;

            Mensagens.Add("Divisão de: " + A + " " + B + " é igual: " + dividirAB);

            return dividirAB;
        }

        public int subtrair(int A, int B)
        {
            int diminuirAB;
            diminuirAB = A - B;

            Mensagens.Add("Subtração de: " + A + " " + B + " é igual: " + diminuirAB);

            return diminuirAB;

        }

        public int Resto(int A, int B)

        {
            int RestoDaDivisaoAB;
            RestoDaDivisaoAB = A % B;

            Mensagens.Add("Resto da: " + A + " " + B + " é igual: " + RestoDaDivisaoAB);

            return RestoDaDivisaoAB;

        }

        public int CalcularCubo(int numero)
        {
            int CuboCalculado;
            CuboCalculado = numero * numero * numero;

            Mensagens.Add("Cubo do numero é: " + CuboCalculado);

            return CuboCalculado;
        }

        public int SomarDiaHoje(int numero, int dia)
        {
            int SomarDiaComAB;
            SomarDiaComAB = numero + dia;

            Mensagens.Add("Somatório de um numero:" + numero + "com o dia: " + dia + " é de: " + SomarDiaComAB);

            return SomarDiaComAB;

        }

        public List<string> Mensagens = new List<string>();

    }
}
