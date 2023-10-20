string[] texts = new string[4];
for (int i = 0; i < texts.Length; i++)
{
    Console.WriteLine("Enter word: ");
    string input = Console.ReadLine()!;
    texts[i] = input;
}

int CountLenNewTexts(string [] texts)
{
    int count = 0;
    for (int i = 0; i < texts.Length; i++)
    {
        if (texts[i].Length <=3)
        {
            count +=1;
        }
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    string gap = "\"";
    for (int i = 0; i < array.Length; i++)
    {
        gap+= array[i].ToString();
        if (i + 1 != array.Length)
        {
            gap += "\", \"";
        }
    }
    Console.Write(gap);
    Console.Write("\"]");
    Console.WriteLine();
}           


PrintArray(texts);