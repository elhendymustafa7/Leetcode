public class Solution {
    public bool IsSubsequence(string s, string t) {
 if (s.Length > t.Length) return false;
        if (s.Length == 0) return true;
            if (s.Length == 1)
            {
                for (int i = 0; i < t.Length; i++)
                {
                    if (s[0] == t[i])
                    {
                        return true;
                    }
                }
                return false;
            }
            int sub = 0;
            for (int i = 0; i < t.Length; i++)
            {
                 if (sub <= s.Length-1)
                {
                    if (s[sub] == t[i])
                    {
                        sub++;
                    }
                }            }
            return sub == s.Length;
    }
}