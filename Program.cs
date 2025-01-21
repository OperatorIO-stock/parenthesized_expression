namespace parenthesized_expression;

class Program
{
    static void Main(string[] args)
    {
        int nestingDepth = 0;
        int maxDepth = 0;

        string answerUser = Console.ReadLine();

        for (int i = 0; i < answerUser.Length; i++)
        {
            if (answerUser[i] == '(')
                nestingDepth++;
            else
                nestingDepth--;

            if (nestingDepth > maxDepth)
                maxDepth = nestingDepth;

            if (nestingDepth < 0)
                break;
        }

        Console.WriteLine(nestingDepth == 0 ? $"{answerUser} - строка корректная и максимум глубины равняется {maxDepth}"
                                            : $"{answerUser} - некорректная строка");
    }
}
