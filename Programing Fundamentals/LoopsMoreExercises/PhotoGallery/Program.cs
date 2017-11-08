using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int photoSizeBytes = int.Parse(Console.ReadLine());
            int photoWidthPixels = int.Parse(Console.ReadLine());
            int photoHeightPixels = int.Parse(Console.ReadLine());
            double photoSize = 0;
            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minutes:D2}");
            if (photoSizeBytes < 1000)
            {
                photoSize = photoSizeBytes;
                Console.WriteLine($"Size: {photoSize}B");

            }
            else if (photoSizeBytes > 1000 && photoSizeBytes < 1000000)
            {
                photoSize = photoSizeBytes / 1000;
                Console.WriteLine($"Size: {photoSize}KB");

            }
            else if (photoSizeBytes > 1000000)
            {
                photoSize = ((double)photoSizeBytes / 1000000);
                Console.WriteLine($"Size: {photoSize}MB");
            }
            if (photoWidthPixels > photoHeightPixels)
            {
                Console.WriteLine($"Resolution: {photoWidthPixels}x{photoHeightPixels} (landscape)");
            }
            else if (photoHeightPixels > photoWidthPixels)
            {
               Console.WriteLine($"Resolution: {photoWidthPixels}x{photoHeightPixels} (portrait)");
            }
            else if (photoWidthPixels == photoHeightPixels)
            {
                Console.WriteLine($"Resolution: {photoWidthPixels}x{photoHeightPixels} (square)");

            }

        }
    }
}
