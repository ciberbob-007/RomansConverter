using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomansProject
{
    /// <summary>
    /// Excersice made by Mijael Vargas
    /// Dual Romans Converter
    /// </summary>
    public class Romans
    {
        private static Dictionary<string, int> ROMANS_INT = 
            new Dictionary<string, int>() {
                { "I",     1 },
                { "IV",    4 },
                { "V",     5 },
                { "IX",    9 },
                { "X",    10 },
                { "XL",   40 },
                { "L",    50 },
                { "XC",   90 },
                { "C",   100 },
                { "CD",  400 },
                { "D",   500 },
                { "CM",  900 },
                { "M",  1000 },
            };

        private static Dictionary<int, string> INT_ROMANS =
            new Dictionary<int, string>() {
                { 1,     "I" },
                { 4,    "IV" },
                { 5,     "V" },
                { 9,    "IX" },
                { 10,    "X" },
                { 40,   "XL" },
                { 50,    "L" },
                { 90,   "XC" },
                { 100,   "C" },
                { 400,  "CD" },
                { 500,   "D" },
                { 900,  "CM" },
                { 1000,  "M" },
            };

        /// <summary>
        /// Given a 32 Int Number, get the Roman Number Format
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Roman Number Format</returns>
        public static string Convert(int number) {
            if (number <= 0 || number >= 10000)
                return "Only numbers between 1 - 9999";

            return Convert(number, 1);
        }

        /// <summary>
        /// Insert a Roman Number string to get INT value, 
        /// Return 0 if a invalid char is found. 
        /// </summary>
        /// <param name="romanString"></param>
        /// <returns>Decimal Number Format</returns>
        public static int Convert(string romanString)
        {
            // Validate if romanString has no invalid character
            if (!romanString.All(c => "IVXCMDL".Contains(c)))
                return 0;
            
            int result = 0;
            
            for (int i = 0; i < romanString.Length; i++)
            {
                if (i + 1 < romanString.Length && 
                    ROMANS_INT.TryGetValue(string.Empty + romanString[i] + romanString[i + 1],
                    out int value))
                {
                    result += value;
                    i++;
                    continue;
                }

                result += ROMANS_INT[romanString[i].ToString()];
            }

            return result;
        }
        
        /// <summary>
        /// Transform an Int 32 number into a 
        /// Roman Number string Format 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private static string Convert(int number, int level)
        {
            if (number == 0)
                return string.Empty;

            int cache = number % (level * 10);

            // Jump level from level * 10
            while (cache == 0)
            {
                level *= 10;
                cache = number % (level * 10);
            }
            
            // Check if cache value is already on map
            if (INT_ROMANS.TryGetValue(cache, out string value))
                return Convert(number - cache, level * 10) + value;
            
            return Convert(number - level, level) + INT_ROMANS[level];
        }
    }
}
