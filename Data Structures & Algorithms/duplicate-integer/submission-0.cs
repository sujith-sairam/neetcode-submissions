public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> hash = new();
        foreach(int num in nums){
            hash.Add(num);
        }

        return hash.Count() != nums.Length;
    }
}