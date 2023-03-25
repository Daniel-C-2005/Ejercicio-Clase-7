using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{


    class Program
    {
        static void advivina()
        {
            const int Oportunidades = 4;
            int numeroCPU, numeroUsuario;
            byte Intentos, BanderaCotrol;
            string linea;
            Random ran = new Random();
            numeroCPU = Convert.ToInt32(ran.Next(1, 20));
            Intentos = 1;
            BanderaCotrol = 0;
            do
            {

                Console.WriteLine("Hola estoy pensando en un´número, cual crees que es?");
                numeroUsuario = Convert.ToInt32(Console.ReadLine());

                if (numeroUsuario == numeroCPU)
                {
                    Console.WriteLine("Yes, adivinaste");
                    BanderaCotrol = 1;

                }
                else
                {
                    if (numeroUsuario < numeroCPU)
                    {
                        Console.WriteLine("El numero que ingresaste es menor, piensa otro numero");
                    }
                    else
                    {
                        Console.WriteLine("El numero que ingresaste es mayor, piensa otro numero");
                    }
                }
                Intentos++;
            } while ((Intentos <= Oportunidades) & (BanderaCotrol == 0));
            if (BanderaCotrol == 0)
            {
                Console.WriteLine("Lo siento no adivinaste");
            }
        }
        static void buscaMayor()
        {
            int mayor = 0;
            int numero = 0;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numero);

                numero = rand.Next(100);
                if (numero > mayor)
                {
                    mayor = numero = numero;
                }

            }
            Console.WriteLine("El numero mayor es:" + mayor);

        }
        static void buscaMenor()
        {
            int menor = 0;
            int numero = 100;
            Random rando = new Random();
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(numero);
                numero = rando.Next(100);
                if (menor < numero)
                {
                    menor = numero = numero;
                }
            }
            Console.WriteLine("El numero menor es:" + menor);

        }
        static void arreglos()
        {
            int[] notas = new int[15];
            Random rnd = new Random();
            Console.WriteLine("Cargando informacion");
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = rnd.Next(100);

            }
            Console.WriteLine("Desplegando informacion");
            int mayor = 0;
            double promedio = 0;
            for (int i = 0; i < notas.Length; i++)
            {

                Console.WriteLine(notas[i]);
                if (notas[i] > mayor)

                {

                    mayor = notas[i] = notas[i];
                }
                promedio = ((promedio + notas[i]) / i);
            }
            Console.WriteLine("El numero mayor es :" + mayor);
            Console.WriteLine("El promedio es:" + promedio);

        }
        static void nombres()
        {
            String[] nombre = new string[11];
            nombre[0] = "Jairo";
            nombre[1] = "Brandom";
            nombre[2] = "Hector";
            nombre[3] = "Yeimi";
            nombre[4] = "Fatima";
            nombre[5] = "Jesus";
            nombre[6] = "Francisco";
            nombre[7] = "Pedro";
            nombre[8] = "Gaby";
            nombre[9] = "Gimena";
            nombre[10] = "Steven";


            Random ran = new Random();
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(i + ":" + nombre[i]);



            }
            Random rnd = new Random();

            string premio1;
            string premio2;
            do
            {
                premio1 = nombre[rnd.Next(0, 10)];
                premio2 = nombre[rnd.Next(0, 10)];

            } while (premio1 == premio2);
            Console.WriteLine("Ganador del coche: " + premio1);
            Console.WriteLine("Ganador de la gallina: " + premio2);
        }


        static void Main(string[] args)
        {

            nombres();
            Console.ReadKey();


        }

    }
}

