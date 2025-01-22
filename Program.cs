namespace parenthesized_expression;

class Program
{
    static void Main(string[] args)
    {
        int nestingDepth = 0;
        int maxDepth = 0;

        char openBracket = '(';
        char closeBracket = ')';


        string answerUser = Console.ReadLine();

        for (int i = 0; i < answerUser.Length; i++)
        {
            if (answerUser[i] != openBracket && answerUser[i] != closeBracket)
            {
                Console.WriteLine($"{answerUser} - некорректная строка");
                return;
            }
        }

        for (int i = 0; i < answerUser.Length; i++)
        {
            if (answerUser[i] == openBracket)
                nestingDepth++;
            else
                nestingDepth--;

            if (nestingDepth > maxDepth)
                maxDepth = nestingDepth;

            if (nestingDepth < 0)
                break;
        }

        if (nestingDepth == 0)
            Console.WriteLine($"{answerUser} - строка корректная и максимум глубины равняется {maxDepth}");
        else
            Console.WriteLine($"{answerUser} - некорректная строка");
    }
}
