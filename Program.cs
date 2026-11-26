Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";

string trimmed = text.Trim();
string upper = text.ToUpper();
string replaced = text.Replace(' ', '_');

Console.WriteLine();
Console.WriteLine(">>> Анализ строки <<<");
Console.WriteLine();
Console.WriteLine($"Исходная строка: [{text}]");
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {CountLetters(text)}");
Console.WriteLine($"Цифр: {CountDigits(text)}");
Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
Console.WriteLine($"Слов: {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям: [{trimmed}]");
Console.WriteLine($"Верхний регистр: [{upper}]");
Console.WriteLine($"Замена пробелов: [{replaced}]");

Console.WriteLine();
Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());

int index = FindCharacterIndex(text, target);

if (index == -1)
{
    Console.WriteLine("Символ не найден");
}
else
{
    Console.WriteLine($"Первый индекс: {index}");
}

int CountCharacter(string text, char target)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (symbol == target)
        {
            count++;
        }
    }

    return count;
}

int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }

    return count;
}

int CountLetters(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }

    return count;
}

int FindCharacterIndex(string text, char target)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    }

    return -1;
}

int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}