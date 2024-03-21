using System;
using Random = UnityEngine.Random;

namespace TweenPlayables
{
    public static class StringTweenUtility
    {
        public static string TweenText(string startValue, string endValue, float t, ScrambleMode scrambleMode = ScrambleMode.None, string customScrambleChars = null)
        {
            int length = Math.Max(startValue.Length, endValue.Length);
            int currentIndex = (int)((length - 1) * t);

            char[] chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                char c = ' ';
                if ((startValue.Length > i && IsNewLine(startValue[i])) || (endValue.Length > i && IsNewLine(endValue[i])))
                {
                    c = '\n';
                }
                else if (i <= currentIndex && endValue.Length > i)
                {
                    c = endValue[i];
                }
                else if (startValue.Length > i)
                {
                    c = startValue[i];
                }
                else
                {
                    switch (scrambleMode)
                    {
                        case ScrambleMode.All:
                            c = SCRAMBLE_CHARS_ALL[Random.Range(0, SCRAMBLE_CHARS_ALL.Length)];
                            break;
                        case ScrambleMode.Uppercase:
                            c = SCRAMBLE_CHARS_UPPERCASE[Random.Range(0, SCRAMBLE_CHARS_UPPERCASE.Length)];
                            break;
                        case ScrambleMode.Lowercase:
                            c = SCRAMBLE_CHARS_LOWERCASE[Random.Range(0, SCRAMBLE_CHARS_LOWERCASE.Length)];
                            break;
                        case ScrambleMode.Numerals:
                            c = SCRAMBLE_CHARS_NUMERALS[Random.Range(0, SCRAMBLE_CHARS_NUMERALS.Length)];
                            break;
                        case ScrambleMode.Custom:
                            if (customScrambleChars.Length == 0) break;
                            c = customScrambleChars[Random.Range(0, customScrambleChars.Length)];
                            break;
                    }
                }
                chars[i] = c;
            }

            return new String(chars);
        }

        private static bool IsNewLine(char c)
        {
            return c == '\n' || c == '\r';
        }

        private const string SCRAMBLE_CHARS_ALL = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private const string SCRAMBLE_CHARS_UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SCRAMBLE_CHARS_LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string SCRAMBLE_CHARS_NUMERALS = "0123456789";
    }
}