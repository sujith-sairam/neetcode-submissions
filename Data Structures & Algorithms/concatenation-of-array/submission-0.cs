public class Solution {
    public int[] GetConcatenation(int[] nums) {

      List<int> list = new List<int>(nums.Length * 2);
      foreach(int num in nums){
        list.Add(num);
      }

     foreach(int num in nums){
        list.Add(num);
      }

       int[] ans = list.ToArray();
       return ans;
    }
}