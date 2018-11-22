using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de Versiones");
            Console.WriteLine("Probando el control de versiones");



            Console.ReadKey();

         

            Console.WriteLine("EJERCICIO 1 POTENCIAS;");
            Console.Write("POTENCIA CON FOR  \n ");
            Console.Write("POTENCIA DE 3 ELEVADO A 4 ES: {0}", potencia1(3,4));
            Console.ReadKey();
            Console.Clear();
            try
            {
                Console.Write("POTENCIA DE -5 ELEVADO A 2 ES: {0}\n", potencia1(-5, 2));
            }catch (Exception ex)
            {
                Console.WriteLine("Error:  " + ex.Message.ToString());
            }
            Console.Write("POTENCIA DE 5 ELEVADO A 5 ES: {0}\n", potencia1(5, 5));

            Console.Write("POTENCIA CON WHILE  \n ");
            potencia2(7, 2);
            Console.Write("POTENCIA CON DO WHILE  \n ");
            potencia2(7, 2);
            Console.ReadKey();
            Console.Clear();

            Console.Write("EJERCICIO 2- ECUACION CUADRATICA   \n ");
            ecucuad(3, 5, 1);
            Console.ReadKey();
            Console.Clear();

            Console.Write("EJERCICIO 3- CALIFIACION Y RESULTADO   \n ");
            calf(10);
            Console.ReadKey();
            Console.Clear();


        }


        // EJERCICIO 1 
        // Calcular la potencia de un numero son usar Math.Pow
        public static double potencia1(int x, int y)
        {
            int pot = 1;
            for (int i = 1; i <= y; i++)
            {
                pot = x * pot;
            }
            return pot;
        }
        public static void potencia2(int x, int y)
        {
            int pot = 1;
            int i = 1;
            while (i <= y)
            {
                pot = x * pot;
                i = i + 1;
            }
            Console.WriteLine(pot);
        }
        public static void potencia3(int x, int y)
        {
            int pot = 1;
            int i = 1;
            do
            {
                pot = x * pot;
                i = i + 1;
            } while (i <= y);
            Console.WriteLine(pot);
        }

        public static void ecucuad(int a, int b, int c)
        {
            // ((-b) (+-) (raiz=b^2-4ac))/(2a)
            // raiz = Math.Sqrt(x);

            double r1, r2, r3, r6, r7;
            double mas, menos;
            double denominador;

            r1 = (b * -1);
            r2 = ((Math.Pow(b, 2)) - (4 * a * c));
            if (r2 > 0)
            {
                r3 = Math.Sqrt(r2);
                r6 = r1 + r3;
                r7 = r1 - r3;
                denominador = (2 * a);
                mas = r6 / denominador;
                menos = r7 / denominador;

                Console.WriteLine("La Ecuacion Cuadratica da con Suma: {0} y con Menos: {1}", mas, menos);
            }
            else
            {
                Console.WriteLine(" COLOQUE OTROS NUMEROS");
            }

        }




        public static void calf(double nota)
        {

            if (nota > 0 && nota <= 10)
            {
                if (nota >= 0 && nota <= 5)
                {
                    Console.WriteLine("SUSPENSO");
                }
                else if (nota > 5 && nota <= 6.5)
                {
                    Console.WriteLine("APROBADO");
                }
                else if (nota > 6.5 && nota <= 8.5)
                {
                    Console.WriteLine("NOTABLE");
                }
                else if (nota > 8.5 && nota < 10)
                {
                    Console.WriteLine("SOBRESALIENTE");
                }
                else
                {
                    Console.WriteLine("MATRICULA DE HONOR");
                }

            }

            else
            {
                Console.WriteLine("Ingrese denuevo su nota");
            }

        }

        public static double potencia (double x , int y)
        {
            if (x<=0)
            {
                throw new Exception(" X debe ser positivo...");
            }
            if (y<=0)
            {
                throw new Exception("Y debe ser positivo...");
            }

            double pot = 1;
            for (int i = 1; i <= y; i++)
            {
                pot = x * pot;
            }
            return pot;
        }
    }
}
