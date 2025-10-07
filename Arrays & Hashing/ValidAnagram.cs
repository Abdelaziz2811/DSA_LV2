public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;
        
        char[] s1 = s.ToCharArray();
        char[] s2 = t.ToCharArray();

        Array.Sort(s1);
        Array.Sort(s2);

        return s1.SequenceEqual(s2);
    }
}