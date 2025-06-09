using System;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
        int[] arr = {a, b, c, d};
        
        Array.Sort(arr);
        
        if (arr[0]==arr[3])
        {
            answer = 1111 * a;
        }
        else if (arr[0] == arr [2] || arr[1] == arr[3])
        {
            if (arr[0] == arr [2])
            {
                answer = (10 * arr[0] + arr[3]) * (10 * arr[0] + arr[3]);
            }
            else if (arr[1] == arr[3])
            {
                answer = (10 * arr[3] + arr[0]) * (10 * arr[3] + arr[0]);
            }
        }
        else if (arr[0] == arr[1] && arr[2] == arr[3])
        {
            answer = (arr[0] + arr[2]) * Math.Abs(arr[0] - arr[2]);
        }
        else if (arr[1] == arr[2] || arr[0] == arr[1] || arr[2] == arr[3])
        {
            if (arr[0] == arr[1])
                answer = (arr[2] * arr[3]);
            else if (arr[1] == arr[2])
                answer = (arr[0] * arr[3]);
            else
                answer = (arr[0] * arr[1]);
        }
        else
        {
            answer = arr[0];
        }
        
        return answer;
    }
}