/*Crear una aplicación que guarde los registros de notas de 25 estudiantes
Debe presentar un menu:
1. Agregar
2. Mostrar
3. Mostrar los 3 primeros lugares
4. Mostrar las notas en orden descendente
5. Salir*/
int [] notas= new int [25];

/*Agregar*/
Console.WriteLine("ingrese las notas de los estudiantes");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"estdiante {i+1}:");
    notas[i] = int.Parse(Console.ReadLine());
}
/*Mostrar*/


/*3 primeros lugares*/


/*Mostrar descendente*/