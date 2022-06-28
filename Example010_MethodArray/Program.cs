//              0   1   2  3   4   5   6   7   8
int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // останавливает алгоритм поиска индекса нужного элемента после первого совпадения
    }
    /* index = index + 1;  */// или так
    index++;
}