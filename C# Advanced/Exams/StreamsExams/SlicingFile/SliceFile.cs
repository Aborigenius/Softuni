using System;
using System.Collections.Generic;
using System.IO;

namespace SlicingFile
{
    class SliceFile
    {
        static List<string> paths;
        static void Main(string[] args)
        {
            paths = new List<string>();
            string sourceFile = "../../../../Files/sliceMe.mp4";
            string destinationDirectory = "../../../../Files/Out/";
            int parts = 4;

            Slice(sourceFile, destinationDirectory, parts);
            Assemble(paths, destinationDirectory);
        }
        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (var reader = new FileStream(sourceFile, FileMode.Open))
            {
                long size = (long)Math.Ceiling(1.0 * reader.Length / parts);
                byte[] buffer = new byte[4096];

                for (int i = 0; i < parts; i++)
                {
                    int bytesRead = 0;
                    string destinationPath = destinationDirectory + $"Part{i}.mp4";
                    paths.Add(destinationPath);
                    using (FileStream writer = new FileStream(destinationPath, FileMode.Create))
                    {
                        while (bytesRead < size)
                        {
                            int bytesCount = reader.Read(buffer, 0, 4096);

                            if (bytesCount == 0)
                            {
                                break;
                            }

                            writer.Write(buffer, 0, bytesCount);
                            bytesRead += bytesCount;
                        }
                    }
                }
            }
        }
        public static void Assemble(List<string> paths, string destinationDirectory)
        {
            byte[] buffer = new byte[4096];
            using (FileStream writer = new FileStream(destinationDirectory + "assembled.mp4", FileMode.Create))
            {
                foreach (var path in paths)
                {
                    using (FileStream readFiles = new FileStream(path, FileMode.Open))
                    {
                        while (true)
                        {
                            int bytes = readFiles.Read(buffer, 0, buffer.Length);

                            if (bytes == 0)
                            {
                                break;
                            }
                            writer.Write(buffer, 0, buffer.Length);
                        }

                    }
                }
            }
        }
    }
}