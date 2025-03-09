public class Solution {
    private static int CalcScale(char c, char cs1, char cs2)
    {
        return (c == cs1 || c == cs2) ? -1 : 1;
    }

    public int RomanToInt(string s)
    {
        int Number = 0;
        char NextChar;
        for (int i = 0; i < s.Length; i++)
        {
            NextChar = (i + 1 < s.Length) ? s[i + 1] : '\0';
            switch (s[i])
            {
                case 'I':
                    Number += 1 * CalcScale(NextChar, 'X', 'V');
                    break;
                case 'V':
                    Number += 5;
                    break;
                case 'X':
                    Number += 10 * CalcScale(NextChar, 'C', 'L');
                    break;
                case 'L':
                    Number += 50;
                    break;
                case 'C':
                    Number += 100 * CalcScale(NextChar, 'M', 'D');
                    break;
                case 'D':
                    Number += 500;
                    break;
                case 'M':
                    Number += 1000;
                    break;

                default:
                    break;
            }
        }
        return Number;
    }
}