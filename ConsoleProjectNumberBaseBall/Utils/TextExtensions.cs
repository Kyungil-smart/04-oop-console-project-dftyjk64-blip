using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectNumberBaseBall.Utils
{
        public static class TextExtensions
        {
            public static void Print(this string text, ConsoleColor color = ConsoleColor.Gray)
            {
                if (color != ConsoleColor.Gray) Console.ForegroundColor = color;

                Console.Write(text);

                if (color != ConsoleColor.Gray) Console.ResetColor();
            }

            public static void Print(this char character, ConsoleColor color = ConsoleColor.Gray)
            {
                if (color != ConsoleColor.Gray) Console.ForegroundColor = color;

                Console.Write(character);

                if (color != ConsoleColor.Gray) Console.ResetColor();
            }
        }
    }

