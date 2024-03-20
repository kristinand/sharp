// See https://aka.ms/new-console-template for more information
string braces = Console.ReadLine();
Console.WriteLine(CheckIsValidBraces(braces).ToString());


bool CheckIsValidBraces(string braces)
{
    Dictionary<char, char> breacesPairs = new Dictionary<char, char>()
{
    {'(', ')' },
    {'{', '}' },
    {'[', ']' },
};

    Stack<char> stack = new Stack<char>();
    foreach (char brace in braces)
    {
        if (breacesPairs.ContainsKey(brace))
        {
            stack.Push(breacesPairs[brace]);

        }
        else if (breacesPairs.ContainsValue(brace) && (stack.Count == 0 || stack.Pop() != brace))
        {
            return false;
        }
    }

    return true;
}
