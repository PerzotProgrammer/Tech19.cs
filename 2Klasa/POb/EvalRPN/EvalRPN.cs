namespace EvalRPN;

class Solution
{
    static void Main()
    {
        // Example 1:
        //
        // Input: tokens = ["2","1","+","3","*"]
        // Output: 9
        // Explanation: ((2 + 1) * 3) = 9

        // Example 2:
        //
        // Input: tokens = ["4","13","5","/","+"]
        // Output: 6
        // Explanation: (4 + (13 / 5)) = 6

        // Example 3:
        //
        // Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
        // Output: 22
        // Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
        //     = ((10 * (6 / (12 * -11))) + 17) + 5
        //     = ((10 * (6 / -132)) + 17) + 5
        //     = ((10 * 0) + 17) + 5
        //     = (0 + 17) + 5
        //     = 17 + 5
        //         = 22

        Solution solution = new();

        Console.WriteLine(solution.EvalRPN(["2", "1", "+", "3", "*"]));
        Console.WriteLine(solution.EvalRPN(["4", "13", "5", "/", "+"]));
        Console.WriteLine(solution.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]));
    }

    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int result))
            {
                stack.Push(result);
            }
            else
            {
                int b = stack.Pop();
                int a = stack.Pop();

                if (token == "+") stack.Push(a + b);
                else if (token == "-") stack.Push(a - b);
                else if (token == "*") stack.Push(a * b);
                else if (token == "/") stack.Push(a / b);
            }
        }

        return stack.Pop();
    }
}