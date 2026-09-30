public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] numsArray = new int[nums.Length];

        for(int i = 0; i<nums.Length;i++){
            int total = 1;

            for(int j = 0; j<nums.Length; j++){
                
                if(j != i){
                    total = total * nums[j];
                }
            }
            numsArray[i] = total;
        }
        return numsArray;
    }
}
