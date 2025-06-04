public class Solution {
    private void swap(char[] s, int left, int right)
    {
        char temp = s[left];
        s[left] = s[right];
        s[right] = temp;
    }
    public void ReverseString(char[] s) {
        int left = 0;
        int right = s.Length - 1;
        while (left < s.Length / 2)
        {
            swap(s, left, right);
            
            left++;
            right--;
        }
    }
}