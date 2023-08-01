int N;

String[] FindAllOfLengthLessThan3Strings(int N)
{
    String[] arrayStr = new String[N];
    String[] resultingList = new String[N];
    int EmptyStringAmount = 0;
    for (int i = 0; i < N; ++i)
    {
        Type type = typeof(ConsoleColor);
        foreach(var name in Enum.GetNames(type))
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
            if (i % Random.Shared.Next(1, N+1) == 0)
                break;
        }
        Console.WriteLine("Enter String #" + i);
        String currentString = Console.ReadLine();
        if (String.IsNullOrEmpty(currentString))
        {
            resultingList[EmptyStringAmount] = "<EmptyString>";
            EmptyStringAmount++;
        }
        else 
            arrayStr[i-EmptyStringAmount] = currentString;
    }
    int pos = 0;
    for (int i = 0; i < arrayStr.Length-EmptyStringAmount; ++i)
    {
        if (arrayStr[i].Length < 4)
            resultingList[EmptyStringAmount+pos++] = arrayStr[i];
    }
    return resultingList;
}


Console.WriteLine("Input string amount");
N = Convert.ToInt32(Console.ReadLine());
String[] resList = FindAllOfLengthLessThan3Strings(N);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Resulting String: [" + String.Join(", ", resList) + "]");
Console.ForegroundColor = ConsoleColor.White;