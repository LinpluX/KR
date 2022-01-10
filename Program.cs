int length = 10;
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
for (int c = 0; c < array.Length; c++)
{
Console.WriteLine($"A{c+1}={array[c]}");
}
Console.WriteLine("Готовый массив");
for (int j = 0; j < array.Length; j++) if ( array[j] % 2 == 0 )
{
    Console.WriteLine($"A{j+1}={array[j]}");
}