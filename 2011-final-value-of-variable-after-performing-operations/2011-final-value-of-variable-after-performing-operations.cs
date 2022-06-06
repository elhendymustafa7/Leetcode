 public class Solution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            
            var w = operations.Where(o => o == "X++" || o == "++X").Count();
            var q = operations.Where(o => o == "X--" || o == "--X").Count();
            return w-q;
        }
    }