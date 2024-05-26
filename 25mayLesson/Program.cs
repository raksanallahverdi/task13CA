
public static class Program
{
    public static void Main()
    {
        string word= "salam";
        string reversedWord = "";
        Stack<char> strings = new();
        for (int i = 0; i <word.Length ; i++)
        {
            strings.Push(word[i]);
        }
        while (strings.Count>0)
        {
            
            reversedWord += strings.Pop();
            
        }
        Console.WriteLine(reversedWord);
        Console.ReadLine();
    }
}
    
    
