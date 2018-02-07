using BashSoft.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BashSoft.DataStructure;

namespace BashSoft
{
    public static class IOManager
    {
        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = SessionData.CurrentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.CurrentPath);
            while (subFolders.Count != 0)
            {
                string currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;
                if (depth - identation < 0)
                {
                    break;
                }
                try
                {
                    OutputWriter.WriteMessageOnNewLine(String.Format($"{new string('-', identation)}{currentPath}"));
                    foreach (var file in Directory.GetFiles(currentPath))
                    {
                        int indexOfLastSlash = file.LastIndexOf("\\");
                        string fileName = file.Substring(indexOfLastSlash);
                        OutputWriter.WriteMessageOnNewLine((new string('-', indexOfLastSlash) + fileName));
                    }
                    foreach (string directoryPath in Directory.GetDirectories(currentPath))
                    {

                        subFolders.Enqueue(directoryPath);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    OutputWriter.WriteMessageOnNewLine(ExceptionMessages.ExampleExeptionMessage);
                }

            }

        }
    }
}
