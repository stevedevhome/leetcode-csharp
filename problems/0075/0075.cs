public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int word1_len = word1.Length;
        int word2_len = word2.Length;
        int len = Math.Max(word1_len, word2_len);
        
        String result = "";
        for (int i = 0; i < len; i++) {
            if (i < word1_len) result = result + word1[i];
            if (i < word2_len) result = result + word2[i];
        }

        return result;
    }
}
