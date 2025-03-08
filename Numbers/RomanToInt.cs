public class Solution {

    public enum RomanSymbol { I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000 };

    public int RomanToInt(string s)
    {
        int Number = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case 'I':
                    Number += (int)RomanSymbol.I;
                    break;
                case 'V':
                    Number += (int)RomanSymbol.V;
                    break;
                case 'X':
                    Number += (int)RomanSymbol.X;
                    break;
                case 'L':
                    Number += (int)RomanSymbol.L;
                    break;
                case 'C':
                    Number += (int)RomanSymbol.C;
                    break;
                case 'D':
                    Number += (int)RomanSymbol.D;
                    break;
                case 'M':
                    Number += (int)RomanSymbol.M;
                    break;

                default:
                    break;
            }
        }
        return Number;
    }
}