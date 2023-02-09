// Пример частотного массива для текстовых данных String: Входные данные:

string text = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.";

// Частотный анализ может выглядеть так:

// Символ пробел/space встречается 41 раз. Частота 12.28%
// Символ о встречается 38 раз.  Частота 11.38%
// Символ и встречается 26 раз.  Частота 7.78%
// Символ т встречается 25 раз.  Частота 7.49%


//////////////////////////////////////////////////////////////////////////////////////



string FillArray(string text)
{
    char[] chars = new char[34]{'й','ц','у','к','е','н','г','ш','щ',
                            'з','ф','ы','в','а','п','р','о','л',
                            'д','ж','э','я','ч','с','м','и','т',
                            'ь','б','ю','-','.',',',' ',};
    string fillText = " ";

    for (int i = 0; i < chars.Length; i++)
    {
        for (int j = 0; j < text.Length; j++)
        {
            if (text[j] == chars[i])
            {
                fillText += text[j];
            }
        }
    }

    return fillText;
}

int[] SearchRepeats(string fillText)
{
    int[] repeatsArray = new int[fillText.Length];

    for (int i = 0; i < fillText.Length; i++)
    {
        int count = 0;

        for (int j = 0; j < fillText.Length; j++)
        {
            if (fillText[i] == fillText[j])
            {
                count++;
            }
        }

        repeatsArray[i] = count;
    }

    return repeatsArray;
}

void PrintRepeats(int[] repeatsArray, string fillText)
{
    double frequency = Math.Round(((double)repeatsArray[0] / repeatsArray.Length) * 100, 2);
    Console.WriteLine($"Символ | пробел |, встречается:  {repeatsArray[0]} раз. Частота: {frequency}%");

    for (int i = 1; i < fillText.Length; i++)
    {
        if (fillText[i] != fillText[i - 1])
        {
            frequency = Math.Round(((double)repeatsArray[i] / repeatsArray.Length) * 100, 2);
            Console.WriteLine($"Символ | {fillText[i].ToString()} |встречается {repeatsArray[i]} раз. Частота {frequency}%");
        }
    }
}
Console.WriteLine(text);
Console.WriteLine();

string fillText = FillArray(text);
int[] repeatsArray = SearchRepeats(fillText);
PrintRepeats(repeatsArray, fillText);



///////////////////////////////////////////////





// 0-20 = 5%

// 21-40 = 7%

// 41-60 = 13%

// 61-80 = 9%

// 81-100 = 6%


///////////////////////////////////////////////////