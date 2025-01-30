public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == target - nums[i])
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }

        return result;
    }
}

// two pointers
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(var p1 = 0; p1<nums.Length; p1++)
        {
            var numberToFind = target - nums[p1];
            for(var p2 = p1+1; p2 < nums.Length; p2++)
            {
                if(nums[p2] == numberToFind)
                    return [p1, p2];
            }
        }

        return null;
    }
}

// hash map

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(nums[i]))
                return [dic[nums[i]], i];
            else
            {
                var numberToFind = target - nums[i];
                dic[numberToFind] = i;
            }
        }
        return null;
    }
}