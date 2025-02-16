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