public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int ,int> PrevMap = new Dictionary<int ,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (PrevMap.ContainsKey(target - nums[i]))
                return new int[] {PrevMap[target - nums[i]], i};
            PrevMap[nums[i]] = i;
        }
        return new int[0];
    }
}