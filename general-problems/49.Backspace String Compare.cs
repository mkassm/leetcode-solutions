// Link: https://leetcode.com/problems/backspace-string-compare

// Using Brute force
// Time: O(n + m)
// Space: O(n + m)
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        return getCleanText(s) == getCleanText(t);
    }
    
    private string getCleanText(string s){
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '#'){
                if (sb.Length > 0)
                    sb.Length--; // remove last character
            }else{
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }
}

// using two pointers
// Time: O(n + m)
// Space: O(1) since only a few integer counters are used regardless of input sizes.
public class Solution {
    public bool BackspaceCompare(string s, string t)
    {
        int p1 = s.Length - 1;
        int p2 = t.Length - 1;

        while (p1 >= 0 || p2 >= 0)
        {
            p1 = GetNextValidIndex(s, p1);
            p2 = GetNextValidIndex(t, p2);

            if (p1 < 0 && p2 < 0) return true;
            if (p1 < 0 || p2 < 0) return false;
            if (s[p1] != t[p2]) return false;

            p1--;
            p2--;
        }

        return true;
    }


    private int GetNextValidIndex(string str, int index)
    {
        int backCount = 0;
        while (index >= 0)
        {
            if (str[index] == '#')
            {
                backCount++;
                index--;
            }
            else if (backCount > 0)
            {
                backCount--;
                index--;
            }
            else
            {
                break;
            }
        }
        return index;
    }
    
}