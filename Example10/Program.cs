int[] array = { 1, 11, 51, 52, 47, 52, 11, 25, 68, 41 };

int n = array.Length;
int find = 52;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
