public class Solution {
    //选择排序法
    public int FindKthLargest(int[] nums, int k) {

        for(int i = 0; i < k; i++){
            //最大值索引
            int index = i;
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[j] > nums[index]){
                    index = j;
                }             
            }
            //交换位置
            int tmp = nums[index];
            nums[index] = nums[i];
            nums[i] = tmp;      
        }
        return nums[k-1];
    }
}