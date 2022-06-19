public class Solution {
    public bool IsValid(string s) {
        Stack left = new Stack();
        foreach(char c in s.ToCharArray()) {
            if (c == '(' || c == '{' || c == '[') {
                left.Push(c); // Get left
            }
            // Compare to right:
            else if (c == ')' && left.Count != 0 && (char) left.Peek() == '(') {
                left.Pop();
            } else if (c == '}' && left.Count != 0 && (char) left.Peek() == '{') {
                left.Pop();
            } else if (c == ']' && left.Count != 0 && (char) left.Peek() == '[') {
                left.Pop();
            } else {
                return false; // no match
            }
        }
      if (left.Count !=0)
                return false;
        return true;
    }
}