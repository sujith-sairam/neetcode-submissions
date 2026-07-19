public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int length = nums.Length;
        for(int i = 0; i < length; i++ ){
            for(int j = 1; j <= length; j++){
                if(nums[i] + nums[j] == target){
                    return [i,j];
                }
            }
        }
        return [0,0];
    }
}
