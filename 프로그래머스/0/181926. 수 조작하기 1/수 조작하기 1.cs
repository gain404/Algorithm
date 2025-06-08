using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;
        
        char[] words = control.ToCharArray();
        
        for (int i = 0; i < words.Length; i++)
        {
            switch (words[i])
            {
                case 'w' :
                    answer += 1;
                    break;
                case 's' :
                    answer -= 1;
                    break;
                case 'd' :
                    answer += 10;
                    break;
                case 'a' :
                    answer -= 10;
                    break;
            }
        }
        
        return answer;
    }
}