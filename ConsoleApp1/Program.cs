using System;
using System.Collections.Generic;

class Program
{
    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            // Opening brackets
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            // Closing brackets
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                // No opening bracket
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                // Check matching pair
                if ((ch == ')' && top != '(') ||
                    (ch == '}' && top != '{') ||
                    (ch == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        // Stack should be empty
        return stack.Count == 0;
    }

    static void Main()
    {
        string input = "{{[[]]}}";

        bool result = IsBalanced(input);

        Console.WriteLine(result
            ? "Balanced"
            : "Not Balanced");
    }
}