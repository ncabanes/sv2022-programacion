using System;

// Aurora (...)
 
/* 29. Muestra los números pares del 10 al 0, ambos inclusive, descendiendo, 
separados por un espacio, sin avanzar de línea, usando "for". 
   
Hazlo dos veces como parte de un mismo programa: primero disminuyendo de 2 en 2 
y luego repítelo disminuyendo de 1 en 1 pero comprobando si el número es par 
antes de escribirlo*/
  
class Ejercicio29
{
    static void Main()
    {   
        for(int i = 10; i >= 0; i = i-2)
        {
            Console.Write("{0} ",i);
            
        }
        Console.WriteLine();

        for(int i = 10; i >= 0; i--)
        {
            if(i % 2 == 0)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}

