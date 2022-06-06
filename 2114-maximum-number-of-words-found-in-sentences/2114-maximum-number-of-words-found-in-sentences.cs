public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0,len =0;
            for (int i = 0; i < sentences.Length; i++)
            {
                len = sentences[i].Split().Length;
                max = Math.Max(max, len);
            }
            return max;
    }
}