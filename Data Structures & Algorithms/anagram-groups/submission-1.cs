public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();

        foreach(string str in strs){
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string newKey = new string(charArray);

            if(!map.ContainsKey(newKey)){
                map[newKey] = new List<string>();
            }

            map[newKey].Add(str);
        }

        return map.Values.ToList();
    }
}
