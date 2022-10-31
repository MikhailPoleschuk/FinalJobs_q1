// Код решения

string[] str = new string[] { "1234", "qwe", "rewrt", "fdsef", "gfd", "0q", "1" };
Console.WriteLine($"Исходный массив строк: {string.Join(" | ", str)}");
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3) count++;
}

string[] newstr = new string[count];
int j = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3)
    {
        newstr[j] = str[i];
        j++;
    }
}

Console.WriteLine($"Новый массив строк: {string.Join(" | ", newstr)}");

