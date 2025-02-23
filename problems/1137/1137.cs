// 1137. N-th Tribonacci Number

public class Solution
{
    private int[] memo;

    public int Tribonacci(int n)
    {
        memo = new int[n + 1];
        for (int i = 0; i <= n; i++)
            memo[i] = -1;
        memo[0] = 0;
        memo[1] = 1;
        memo[2] = 1;
        int result = tribo(n);
        return result;
    }

    public int tribo(int n)
    {
        if (memo[n] != -1) return memo[n];
        memo[n] = tribo(n - 1) + tribo(n - 2) + tribo(n - 3);
        return memo[n];
    }
}

