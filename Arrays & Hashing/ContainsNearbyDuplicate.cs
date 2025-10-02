public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> NumIndxMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (NumIndxMap.ContainsKey(nums[i]))
            {
                if (i - NumIndxMap[nums[i]] <= k)
                    return true;
                NumIndxMap[nums[i]] = i;
            }
            else
                NumIndxMap.Add(nums[i], i);
        }
        return false;
    }