public class Solution {
    public int FindRepeatNumber(int[] nums) {
        // 排序+遍历
        Array.Sort(nums);
        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] == nums[i-1]) {
                return nums[i];
            }
        }
        return -1;

        /*
            时间复杂度：O(logn)
            空间复杂度：O(1)
        */
    }
}