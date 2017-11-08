using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int N = int.Parse(Console.ReadLine());
            while (AreThereLiveGrapes(grapes, N))
            {
                for (int cnt = 0; cnt < N; cnt++)
                {
                    GrapesBloom(grapes);
                }
                KillWeakGrapes(grapes, N);
            }

            PrintLiveGrapes(grapes);
        }
        static void PrintLiveGrapes(List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (IsAlive(grapes[i]))
                {
                    Console.Write(grapes[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static bool IsAlive(int grape)
        {
            return grape > 0;
        }
        static bool AreThereLiveGrapes(List<int> grapes, int threshold)
        {
            int LiveGrapes = 0;
            for (int i = 0; i < grapes.Count; i++)
            {
                if (IsStrongenough(grapes[i], threshold))
                {
                    LiveGrapes++;
                }
            }
            return LiveGrapes >= threshold;
        }
        static void KillWeakGrapes(List<int> grapes, int threshold)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (IsStrongenough(grapes[i], threshold))
                {
                    grapes[i] = 0;
                }
            }
        }
        static void GrapesBloom(List<int> grapes)
        {
            for (int index = 0; index < grapes.Count; index++)
            {
                if (IsAlive(grapes[index]))
                {
                    continue;
                }
                if (IsGreaterGrape(grapes, index))
                {
                    grapes[index] += 3;
                }
                else if (IsLesserGrape(grapes, index))
                {
                    grapes[index]--;
                }
                else
                {
                    grapes[index]++;
                }
            }
        }
        static bool IsLesserGrape(List<int> grapes, int grapeIndex)
        {
            return IsGreaterGrape(grapes, grapeIndex - 1) || IsGreaterGrape(grapes, grapeIndex + 1);
        }
        static bool IsGreaterGrape(List<int> grapes, int grapeIndex)
        {
            if (grapeIndex <= 0 || grapeIndex >= (grapes.Count -1))
            {
                return false;
            }
            int grapePower = grapes[grapeIndex];
            return (grapePower > grapes[grapeIndex - 1] && grapePower > grapes[grapeIndex + 1]);
        }
        static bool IsStrongenough(int grape, int threshold)
        {
            return grape >= threshold;
        }
    }
}
