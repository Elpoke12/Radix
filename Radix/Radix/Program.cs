using System;


namespace Radix
{
    class Radixgg
    {
        public void Radix(int[] Array) //Declaramos un metodo conparametros
        {
            int[] Vektor = new int[Array.Length]; //Con otro arreglo, que le daremos el mismo tamano para poder movernos
            int b, temp;
            for (int indice = 0; indice < Array.Length; indice++) //Aqui nos iremos moviendo en el arrelo
            {
                temp = Array[indice]; //Con la variable temporal que declaramos, le igualaremos el indice
                b = indice - 1; //Y declaramos b como -1 para tomar desde el valor anerior
                while (b >= 0 && Array[b] > temp) //Cuando nuestro arreglo principal se igual a b lo movera
                {
                    Array[b + 1] = Array[b]; 

                    b--; //Disminuira lo que tenga en b
                }
               
                Array[b + 1] = temp;
            }
        }
        public void Display(int[] arreglo) //Desplegamos nuestro array
        {
            Console.WriteLine("\nNo ordenado"); 
            foreach (var item in arreglo)
            {
                Console.Write(" " + item);

            }

            Console.WriteLine();
            Console.WriteLine("Ordenado");
            Radix(arreglo);
            foreach (var item in arreglo)
            {
                Console.Write(" " + item);

            }
        }
             static void Main(string[] args)
            {
                Radixgg metodo = new Radixgg(); //Instanciamos nuestra clase
            int[] Vek1 = new[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; 
                metodo.Display(Vek1);
            int[] Vek2 = new[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
                metodo.Display(Vek2);
            int[] Vek3 = new[] { 10, 40, 36, -5, 24, 2, 5, 8 };
                metodo.Display(Vek3);
            int[] Vek4 = new[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
                metodo.Display(Vek3);
                int[] Vek5= new[] { 25, 108, 1024, 12, 351, 251, 34 };
            metodo.Display(Vek5);
                Console.ReadKey();
            }

        }
    }

