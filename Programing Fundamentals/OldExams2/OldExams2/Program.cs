using System;

namespace OldExams2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var half = n / 2;
            var inTheMiddle = 2 * n - 2 * half - 4;
            var width = 2 * n;
            #region TopRow
            Console.Write("{0}{1}{2}", ("/"), (new string('^', half)), ('\\'));
            Console.Write(new string('_', inTheMiddle));
            Console.Write("{0}{1}{2}", ("/"), (new string('^', half)), ('\\'));
            Console.WriteLine();
            #endregion
            #region Middle
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}{1}{0}", ('|'), new string(' ', width - 2));
            }
            #region MissingRow
            Console.Write("{0}{1}", ('|'), new string(' ', half +1));
            Console.Write(new string('_', inTheMiddle));
            Console.Write("{0}{1}", new string(' ', half +1), ('|'));
            Console.WriteLine();
            #endregion

            #endregion
            #region BottomRow
            Console.Write("{0}{1}{2}", ("\\"), (new string('_', half)), ('/'));
            Console.Write(new string(' ', inTheMiddle));
            Console.Write("{0}{1}{2}", ("\\"), (new string('_', half)), ('/'));
            Console.WriteLine();
            #endregion

        }
    }
}