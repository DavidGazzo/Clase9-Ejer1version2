/*Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1)      Pedir al usuario la longitud de un vector
2)      Crear el vector del tamaño ingresado.
3)      Llenar el mismo con datos aleatorios
4)      Mostrar el vector por pantalla
5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero;
        el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. 
        En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, 
        una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.  
        Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
        Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
6)      Mostrar el vector nuevamente.
*/

Console.WriteLine("Invertir valores de un vector");
Console.WriteLine("-----------------------------");

Console.Write("Ingrese la longitud del vector: ");
int longVector = int.Parse(Console.ReadLine());

int[] vectorNumeros = new int[longVector];

// Cargar valores en vector
for (int i = 0; i < vectorNumeros.Length; i++)
{
    Console.Write($"Ingrese el valor nº {i + 1}: ");
    vectorNumeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Los valores del vector son los siguentes:");

// Mostrar los valores del vector
for (int i = 0; i < vectorNumeros.Length; i++)
{
    Console.WriteLine($"    Valor nº {i + 1}: {vectorNumeros[i]}");
}

// Invertir la posición de los valores del vector
// Uso vector auxiliar
int auxInic = 0;
int auxFinal = 0;
int contPosic = vectorNumeros.Length;
int vueltas = vectorNumeros.Length / 2;
for (int i = 0; i < vueltas; i++)
{
    auxInic = vectorNumeros[i];
    auxFinal = vectorNumeros[vectorNumeros.Length - i - 1];
    vectorNumeros[i] = auxFinal;
    vectorNumeros[vectorNumeros.Length - i - 1] = auxInic;
}
// Mostrar vector invertido
Console.WriteLine("-----------------------------");
Console.WriteLine("Vector invertido");

for (int i = 0; i < vectorNumeros.Length; i++)
{
    Console.WriteLine($"    Valor nº {i + 1}: {vectorNumeros[i]}");
}

Console.WriteLine("Pulse una tecla para terminar...");
Console.ReadKey();