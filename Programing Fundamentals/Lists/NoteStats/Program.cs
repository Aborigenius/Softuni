using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStats
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialNotes = new List<string>(new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" });
            List<double> notesFreqs = new List<double>(new double[] { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 });

            double[] inputFreqs = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<string> totalNotes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            double naturalsSum = 0;
            double sharpsSum = 0;

            for (int i = 0; i < inputFreqs.Length; i++)
            {
                int index = notesFreqs.IndexOf(inputFreqs[i]);
                string currentNote = initialNotes[index];
                double freq = notesFreqs[index];

                totalNotes.Add(currentNote);
                if (IsNatural(currentNote))
                {
                    naturals.Add(currentNote);
                    naturalsSum += freq;
                }
                else
                {
                    sharps.Add(currentNote);
                    sharpsSum += freq;
                }
            }
            Console.WriteLine($"Notes: {string.Join(" ", totalNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }
        static bool IsNatural(string currentNote)
        {
            return (currentNote.Length == 1);
        }
    }
}
