using System;
using System.IO;

namespace CopyBinaryFile
{
    class CopyBinary
    {
        static void Main(string[] args)
        {
            var source = new FileStream("../../../../Files/copyMe.png", FileMode.Open);

            using (source)
            {
                var destination = new FileStream("../../../../Files/copiedFile.png", FileMode.Create);
                using (destination)
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        destination.Write(buffer, 0, readBytes);
                    }

                }
            }
        }
    }
}
