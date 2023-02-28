using System;

    //1. El programa debe solicitar al usuario que ingrese un número entero positivo N mayor que cero.
try
{
    Console.WriteLine("Bienvenido, querido usuario.\nNecesito que ingreses un número entero mayor que 0:\n");
    int N;
    N = Convert.ToInt32(Console.ReadLine());


    //2. El programa debe declarar una variable entera llamada "suma" y asignarle el valor cero.
    int suma = 0;

    //3. Utilizando una estructura de control adecuada, el programa debe calcular la suma de los primeros N números
    //enteros positivos y almacenar el resultado en la variable "suma".
    if (N <= 0)
    {
        Console.Write("\nEso no es un número mayor que 0...\n");
    }
    else
    {
        for (int i = 1; i <= N; i++)
        {
            suma += i;
        }

        Console.WriteLine();
        Console.Write(N);

        int n = 1;
        while (n < N)
        {
            Console.Write(" + " + (N - n));
            n++;
        }

        Console.Write(" = " + suma);
        if (N != 1)
        {
            Console.WriteLine("\nBastante genial, ¿no?");
            Console.WriteLine("Calculé la suma de los primeros " + N + " números enteros positivos.");
        }
        else
        {
            Console.WriteLine("\nSe supone que tengo que sumar todos los números enteros menores a 1, pero no hay ninguno.:(");
            Console.WriteLine("¡A la próxima prueba con un número mayor!");
        }

        //4. Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla todos los números enteros positivos
        //menores o iguales que N.
        Console.WriteLine("\nEstos son todos los números enteros positivos menores o iguales que " + N + ":\n");

        int n2 = 1;
        while (n2 <= N)
        {
            Console.WriteLine(n2);
            n2++;
        }

        //5. Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla todos los números enteros impares menores o
        //iguales que N.
        Console.WriteLine("\nEstos son todos los números enteros impares menores o iguales que " + N + ":\n");

        int n3 = 0;
        do
        {
            if (n3 % 2 != 0)
            {
                Console.WriteLine(n3);
            }
            n3++;
        } while (n3 <= N);

        //6. Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla la tabla de multiplicar del número N,
        //desde el 1 hasta el 10.
        Console.WriteLine("\nEsta es la tabla de multiplicar de " + N + ":\n");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " x " + N + " = " + i * N + "\n");
        }

        //7. Utilizando una estructura de control adecuada, el programa debe imprimir en la pantalla la secuencia de números enteros positivos
        //que comienzan en N y se incrementan en 2 hasta que se alcance un valor mayor que 20.
        Console.WriteLine("\nEsta es la secuencia de números que comienzan en " + N + " y se incrementan en 2 hasta alcanzar un valor mayor que 20:\n");
        int n4 = N;
        if (N > 20)
        {
            Console.WriteLine("Vaya, parece que el número ingresado ya es mayor a 20...");
        }
        else
        {
            while (n4 <= 22)
            {
                Console.WriteLine(n4);
                n4 += 2;
            }
        }

        //8. El programa debe imprimir en la pantalla el valor de la variable "suma" al final del proceso.
        Console.WriteLine("\nEl resultado de la suma es: " + suma + ". Por si se te había olvidado.");
        Console.WriteLine("¡Gracias por usar mi programa!");
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nUps, parece que te equivocaste en algo. ¡Pero no te desanimes! Te sugiero que lo intentes de nuevo. <3");
    Console.Write("La excepción es: " + ex.Message + "\n");
}