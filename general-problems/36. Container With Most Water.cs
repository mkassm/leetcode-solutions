// Link: https://leetcode.com/problems/container-with-most-water

// Time: O(n)
// Space: O(1)

// using two pointers and greedy algorithm 
public class Solution {
    public int MaxArea(int[] height) {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            // area = height (minimum) * width (distance between two pointers)
            var currArea = Math.Min(height[left], height[right]) * (right - left);
						// update max area
            maxArea = Math.Max(maxArea, currArea);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;   
    }
}

// brute force (timeout exception)
// Time: O(n^2)
// Space: O(1)

public class Solution {
    public int MaxArea(int[] height) {
        var maxArea = 0;
        if(height.Length < 2)
            return maxArea;

        for(var a = 0; a < height.Length; a++)
        {
            for(var b = a + 1; b< height.Length; b++)
            {
                // calucalte maxArea
                // area = hight * width
                var currentArea = Math.Min(height[a], height[b]) * (b-a);
                if (currentArea > maxArea)
                    maxArea = currentArea;
            }
        }

        return maxArea;
    }
}