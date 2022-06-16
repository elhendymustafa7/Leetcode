using System.Text.RegularExpressions;

public class Solution {
      public bool IsPalindrome(string s)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "").ToLower();
            Stack<char> InputStack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                InputStack.Push(s[i]);
            }
            string w = string.Empty;
            while (InputStack.Count > 0)
            {
                w += InputStack.Pop();
            }
            return w.Equals(s);
        }
}