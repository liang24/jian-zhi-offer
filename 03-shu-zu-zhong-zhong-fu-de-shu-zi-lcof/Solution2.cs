public class Solution {
    public int FindRepeatNumber(int[] nums) {
        // 使用哈希表
        HashSet<int> hs = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(hs.Contains(nums[i])) {
                return nums[i];
            } 
            hs.Add(nums[i]);
        }
        return -1;

        /*
            时间复杂度：O(n)
            空间复杂度：O(n)
        */
    }
}