public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> hash = new();
        foreach(int num in nums){
            if(hash.Contains(num)){
            return true;
            }
            hash.Add(num);
        }

        return false;
    }
}