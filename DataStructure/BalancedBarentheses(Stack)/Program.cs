using System.Security.Cryptography.X509Certificates;

namespace BalancedBarentheses_Stack_
{

    // Write a c# program to balance open and close brackets
    internal class Program
    {

        public class Stack
        {
            char[] array;
            int top;

            public Stack(int size)
            {
                array = new char[size];
                top = -1;
            }

            public bool isEmpty()
            {
                return top == -1;
            }

            public void push(char value)
            {
                if (top == array.Length -1) 
                {
                    return;
                }
                top++;
                array[top] = value;
            }

            public char pop()
            {
                if (!isEmpty())
                {
                    char value = array[top];
                    top--;
                    return value;
                }
                return '\0';
            }

            public char peek()
            {
                if (isEmpty())
                {
                    return '\0';
                }
                return array[top];
            }
        }

        public class Balanced
        {
            private bool checkPair(char open, char close)
            {
                if (open == '(' && close == ')') return true;
                else if (open == '{' && close == '}') return true;
                else if (open == '[' && close == ']') return true;
                else return false;
            }

            private bool isBalanced(string expression)
            {
                Stack stack = new Stack(expression.Length);

                for (int i = 0; i < expression.Length; i++)
                {
                    char ch = expression[i];

                    if (ch == '(' || ch == '{' || ch == '[')
                    {
                        stack.push(ch);
                    }
                    else if (ch == ')' || ch == '}' || ch == ']')
                    {
                        if (stack.isEmpty()) return false;
                        else if (checkPair(stack.peek(), ch) == false) return false;
                        stack.pop();
                    }
                }
                return stack.isEmpty();
            }

            public string checkBalance(string exp)
            {
                if (isBalanced(exp)) return "Balanced";
                else return "Not Balanced";
            }
        }

        static void Main(string[] args)
        {
            Balanced balanced = new Balanced();
            string expression = "{[(yousef loves hager)]}";
            Console.WriteLine(balanced.checkBalance(expression));
        }
    }
}
