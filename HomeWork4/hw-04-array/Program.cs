var set = new int[] { 15, 12, -6, 8, -9, 12, 0};

Console.WriteLine("Вывод неотсортированного массива: ");
for (int i = 0; i < set.Length; i++)
{
    Console.WriteLine(set[i]);
}
int temp;

    for (int i = 0; i < set.Length - 1; i++)
{
    for (int j = i + 1; j < set.Length; j++)
    {
        if (set[i] > set[j])
        {
            temp = set[i];
            set[i] = set[j];
            set[j] = temp;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Вывод отсортированного массива: ");
for (int i = 0; i < set.Length; i++)
{
    Console.WriteLine(set[i]);
}
