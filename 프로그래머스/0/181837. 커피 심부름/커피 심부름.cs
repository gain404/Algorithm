using System;
using System.Linq;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        
        foreach (var i in order)
        {
            if (i.Contains("americano") || i == "anything")
                answer += 4500;
            else if (i.Contains("cafelatte"))
                answer += 5000;
        }
        
        return answer;
    }
}