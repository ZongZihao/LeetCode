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

    //依据快排思想
    public int FindKthLargest2(int[] nums, int k) {

        return Find(nums, 0, nums.Length - 1, k);
        
    }
    
    public int Find(int[] nums, int left, int right, int k){
        
        //分区返回轴心点
        int pivot = Partition(nums, left, right);
        
        if(pivot + 1 == k){
            return nums[pivot];
        }else if(pivot + 1 < k){
            return Find(nums, pivot + 1, right, k);
        }else{
            return Find(nums, left, pivot - 1, k);
        }
    }
    
    public int Partition(int[] nums, int left, int right){
        
        //选取pivot
        int pivot = right;
        //快慢两指针,区分已处理区间
        int slow = left;
        int fast = left;
        for(; fast <= right; fast++){
            //倒叙排序
            if(nums[fast] >= nums[pivot]){
                //交换
                int tmp = nums[slow];
                nums[slow] = nums[fast];
                nums[fast] = tmp;
                //已处理区间+1
                slow++;
            }
        }
        return slow - 1;
        
    }
}