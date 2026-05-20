/*Crear una aplicación que guarde los registros de notas de 25 estudiantes
Debe presentar un menu:
1. Agregar
2. Mostrar
3. Mostrar los 3 primeros lugares
4. Mostrar las notas en orden descendente
5. Salir*/
int [] notas= new int [25];

/*Agregar - Integrante 1*/


/*Mostrar - Integrante 2*/


/*3 primeros lugares - Integrante 3*/


/*Mostrar descendente - Integrante 4*/
for (int i = 0; i < notas.Length; i++)
{
    for (int j = 0; j < notas.Length - 1; j++)
    {
        if (notas[j] < notas[j + 1])
        {
            int temp = notas[j];
            notas[j] = notas[j + 1];
            notas[j + 1] = temp;
        }
    }
}
Console.WriteLine("Notas en orden descendente:");
for (int i = 0; i < notas.Length; i++)  
{
    Console.WriteLine(notas[i]);
}