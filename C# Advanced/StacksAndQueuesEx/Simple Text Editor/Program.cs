using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            Stack<string> rememberStack = new Stack<string>();

            for (int i = 0; i < input; i++)
            {
                var commandsInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int action = int.Parse(commandsInput[0]);

                switch (action)
                {
                    case 1:
                        if (commandsInput.Length > 1)
                        {
                            rememberStack.Push(text.ToString());
                            text.Append(commandsInput[1]);
                        }
                        break;
                    case 2:
                        if (commandsInput.Length > 1)
                        {
                            var removeCount = int.Parse(commandsInput[1]);

                             rememberStack.Push(text.ToString());
                            
                            if (removeCount > text.Length)
                            {
                                text.Clear();
                                break;
                            }
                            text.Remove(text.Length - removeCount, removeCount);
                        }
                        break;
                    case 3:
                        if (commandsInput.Length > 1)
                        {
                            var indexOf = int.Parse(commandsInput[1]);
                            if (indexOf <= text.Length && indexOf > 0)
                            {
                                Console.WriteLine(text[indexOf - 1]);
                            }
                        }
                        break;
                    case 4:
                        text.Clear();
                        text.Append(rememberStack.Pop());
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
