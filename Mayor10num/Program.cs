int[] datos = new int[10];
int i, mayor = 0, j = 0;
for (i = 0; i < 10; i++)
{
	Console.Write("Digite el valor de la posicion {0}: ", (i + 1));
datos[i] = Convert.ToInt32(Console.ReadLine());
}
while (j < 10)
{
	if (datos[j] > mayor)
		mayor = datos[j];
	j++;
}
Console.WriteLine("El mayor de los datos es: {0}", mayor);
Console.ReadKey(true);