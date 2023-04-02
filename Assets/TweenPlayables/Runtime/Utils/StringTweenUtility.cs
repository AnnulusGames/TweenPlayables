using System;
using Random = UnityEngine.Random;

namespace AnnulusGames.TweenPlayables
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
                if (i <= currentIndex && endValue.Length > i)
                {
                    chars[i] = endValue[i];
                }
                else if (startValue.Length > i)
                {
                    chars[i] = startValue[i];
                }
                else
                {
                    switch (scrambleMode)
                    {
                        case ScrambleMode.All:
                            chars[i] = SCRAMBLE_CHARS_ALL[Random.Range(0, SCRAMBLE_CHARS_ALL.Length)];
                            break;
                        case ScrambleMode.Uppercase:
                            chars[i] = SCRAMBLE_CHARS_UPPERCASE[Random.Range(0, SCRAMBLE_CHARS_UPPERCASE.Length)];
                            break;
                        case ScrambleMode.Lowercase:
                            chars[i] = SCRAMBLE_CHARS_LOWERCASE[Random.Range(0, SCRAMBLE_CHARS_LOWERCASE.Length)];
                            break;
                        case ScrambleMode.Numerals:
                            chars[i] = SCRAMBLE_CHARS_NUMERALS[Random.Range(0, SCRAMBLE_CHARS_NUMERALS.Length)];
                            break;
                        case ScrambleMode.Custom:
                            if (customScrambleChars.Length == 0) break;
                            chars[i] = customScrambleChars[Random.Range(0, customScrambleChars.Length)];
                            break;
                    }
                }
            }

            return new String(chars);
        }

        private const string SCRAMBLE_CHARS_ALL = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private const string SCRAMBLE_CHARS_UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SCRAMBLE_CHARS_LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string SCRAMBLE_CHARS_NUMERALS = "0123456789";
    }
}