
// 0283 - MoveZeros
// 2025.02.02

public class Solution {
    public void MoveZeroes(int[] nums) {
        int len = nums.Length;
        int iBlockEnd = len - 1;
        
        // find first non-zero from the right.
        while ((iBlockEnd > 0) && (nums[iBlockEnd] == 0))
            iBlockEnd--;
        int iBlockStart = iBlockEnd;

        // swap loop
        while (iBlockStart > 0) {
            int iZero = iBlockStart;
            // find first zero from the right.
            while ((iZero >= 0) && (nums[iZero] != 0))
                iZero--;
            if (iZero < 0) break;

            iBlockStart = iZero + 1;
            // move non-zero block to the left
            for (int i = iBlockStart;  i <= iBlockEnd; i++) 
                nums[i - 1] = nums[i];
            nums[iBlockEnd] = 0;
            iBlockEnd--;
            iBlockStart--;
        }
    }
}