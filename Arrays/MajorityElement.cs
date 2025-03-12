public class Solution {
    int TimesRepeated = 0;
    int number = 0;
    public int MajorityElement(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (nums[i] == nums[j]) 
                    TimesRepeated++;
            }
            if (TimesRepeated > (nums.Length / 2))
            {
                number = nums[i];
                break;
            }
            TimesRepeated = 0;
        }
        return number;
    }
}