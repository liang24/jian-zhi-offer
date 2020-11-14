public class Solution {
    public string ReplaceSpace(string s) {
        /*
            使用辅助空间，把非空格的添加到list，空格的添加三个字符%20到list
        */

        if(s == null || s.Length == 0) {
            return s;
        }
        List<char> c = new List<char>();
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == ' ') {
                c.Add('%');
                c.Add('2');
                c.Add('0');
            } else {
                c.Add(s[i]);
            }
        }

        return new string(c.ToArray());

        /*
            时间复杂度：O(n)
            空间复杂度：O(n)
        */
    }
}