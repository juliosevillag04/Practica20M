/*Crear una aplicación que guarde los registros de notas de 25 estudiantes
Debe presentar un menu:
1. Agregar
2. Mostrar
3. Mostrar los 3 primeros lugares
4. Mostrar las notas en orden descendente
5. Salir*/
int [] notas= new int [25];

/*Agregar*/


/*Mostrar*/
Console.WriteLine("Mostrando notas.");
for (int i = 0; i < 25; i++)
{
    if (notas[i]<70) Console.ForegroundColor = ConsoleColor.red;
    else Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Nota {i+1}: {notas[i]}");
    Console.ResetColor();
} 


/*3 primeros lugares*/



/*Mostrar descendente*/