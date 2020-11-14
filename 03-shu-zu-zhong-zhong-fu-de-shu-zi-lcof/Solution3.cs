public class Solution {
    public int FindRepeatNumber(int[] nums) {
        /*
            由于数组的值是在[0, n)，可采用遍历数组
            如果 i != nums[i]，将下标为 i 与下标为 nums[i] 的位置交换，直到 i == nums[i]
            如果期间存在nums[i] == nums[nums[i]]，即值对应的下标位置已经存在了，表示出现重复
        */

        for(int i = 0; i < nums.Length; i++) {
            while(i != nums[i]) {                
                if(nums[i] == nums[nums[i]]) {
                    return nums[i];
                }

                Swap(nums, i, nums[i]);
            }
        }
        return -1;
        /*
            时间复杂度：O(n)
            空间复杂度：O(1)，原地排序
        */
    }

    private void Swap(int[] nums, int i, int j) {
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}