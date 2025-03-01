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