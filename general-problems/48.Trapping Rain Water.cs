// Link: https://leetcode.com/problems/trapping-rain-water/description

// Using Brute force - Time limit
// Time: O(n^2)
// Space: O(1)
public class Solution {
    public int Trap(int[] height) {
        var totalWater = 0;
        for(var p = 0; p < height.Length; p++)
        {
            var leftP = p;
            var rightP = p;
            var maxLeft = 0;
            var maxRight = 0;
            while(leftP >= 0)
            {
                maxLeft = Math.Max(maxLeft, height[leftP]);
                leftP--;
            }

            while(rightP < height.Length)
            {
                maxRight = Math.Max(maxRight, height[rightP]);
                rightP++;
            }

            var currentWater = Math.Min(maxLeft, maxRight) - height[p];
            if(currentWater >= 0)
                totalWater += currentWater;
        }

        return totalWater;
    }
}

// using two pointers
// Time: O(n)
// Space: O(1)
/*
1. Identify the pointer with the lesser value
2. Is this pointer value greater than or equal to max on that side
  yes -> update max on that side
  no -> get water for pointer, add to total
3. move pointer inwards
4. repeat for other pointer
 */

public class Solution {
    public int Trap(int[] height) {
        var totalWater = 0;
        var maxRight = 0;
        var maxLeft = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            if (height[right] > height[left])
            {
                if (height[left] > maxLeft)
                    maxLeft = height[left];
                else
                {
                    var currentWater = maxLeft - height[left];
                    if (currentWater >= 0)
                        totalWater += currentWater;
                }
                left++;
            }
            else
            {
                if (height[right] > maxRight)
                    maxRight = height[right];
                else
                {
                    var currentWater = maxRight - height[right];
                    if (currentWater >= 0)
                        totalWater += currentWater;
                }
                right--;
            }
        }

        return totalWater;
    }
}