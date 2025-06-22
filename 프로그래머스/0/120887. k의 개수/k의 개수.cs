using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        char t = k.ToString()[0];
        
        for (; i <= j; i++)
        {
            string s = i.ToString();
            for (int u = 0; u < s.Length; u++)
            {
                if (s[u] == t)
                {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}