using System.Collections;
public class Solution {
    public bool IsIsomorphic(string s, string s2) {
         Hashtable hash = new Hashtable();

            for (int i = 0; i < s.Length; i++)
            {
                if (hash.ContainsKey(s[i]) || hash.ContainsValue(s2[i]))
                {
                    if (s2[i].Equals(hash[s[i]]))
                    {
                        continue;
                    }
                    return false;

                }
                hash.Add(s[i], s2[i]);
            }
            return true;
    }
}