using System.Text;
using System.Collections.Generic;

namespace OldPhonePadApp
{
    public class OldPhonePadConverter
    {
        private static readonly Dictionary<char, string> KeypadMap = new Dictionary<char, string>
        {
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" }
            // Note: '0' and '1' buttons are not handled as their behavior
            // for characters can vary and was not specified in the prompt.
        };

        public static string OldPhonePad(string input)
        {
            if (string.IsNullOrEmpty(input) || !input.EndsWith("#"))
            {
                // Or throw an ArgumentException for invalid input format.
                return string.Empty;
            }

            var resultBuilder = new StringBuilder();
            char previousChar = '\0';
            int pressCount = 0;

            foreach (char currentChar in input)
            {
                if (currentChar == '#')
                {
                    AppendCharacter(resultBuilder, previousChar, pressCount);
                    break;
                }

                if (currentChar == '*')
                {
                    if (pressCount > 0)
                    {
                        previousChar = '\0';
                        pressCount = 0;
                    }
                    else if (resultBuilder.Length > 0)
                    {
                        resultBuilder.Length--;
                    }
                    continue;
                }

                if (currentChar == ' ')
                {
                    AppendCharacter(resultBuilder, previousChar, pressCount);
                    previousChar = '\0';
                    pressCount = 0;
                    continue;
                }

                if (currentChar == previousChar)
                {
                    pressCount++;
                }
                else
                {
                    AppendCharacter(resultBuilder, previousChar, pressCount);
                    previousChar = currentChar;
                    pressCount = 1;
                }
            }

            return resultBuilder.ToString();
        }

        private static void AppendCharacter(StringBuilder builder, char character, int count)
        {
            if (KeypadMap.TryGetValue(character, out var mapping))
            {
                int index = (count - 1) % mapping.Length;
                builder.Append(mapping[index]);
            }
        }
    }
}
