public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> IntSet = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (IntSet.Contains(nums[i]))
                return true;
            IntSet.Add(nums[i]);
        }
        return false;
    }
}