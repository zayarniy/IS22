using System;
using System.IO;
namespace Exc61
{
    class Program
    {

        static void Plus(int a,int b,int sum)
        {
            sum = a + b;
        }

        static void CountChars(string s,out int countVowels,out int countConsonants)
        {
            countConsonants = countVowels = 0;
            char[] vowels = { 'a', 'e', 'u', 'i' };
            char[] consonatntes = { 'q', 'w', 'r', 't', 'y', 'p','b','c' };
            foreach (char c in s)
            {
                if (Array.IndexOf(vowels, Char.ToLower(c)) >= 0) countVowels++;
                if (Array.IndexOf(consonatntes, Char.ToLower(c)) >= 0) countConsonants++;
            }
        }
        static void Main(string[] args)
        {
            int a=4, b=3, sum=0;
            Plus(a, b, sum);
            string s=File.ReadAllText(args[0]);
            Console.WriteLine(s);
            int cv, cc;
            CountChars(s, out cv, out cc);
            Console.WriteLine($"Количество гласных:{cv}");
            Console.WriteLine($"Количество согласных:{cc}");
        }
    }
}