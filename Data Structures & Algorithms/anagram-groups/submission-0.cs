public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        List<List<string>> resultList = new List<List<string>>();
        HashSet<string> hashsetValues = new HashSet<string>();

        for(int i = 0; i < strs.Length; i++){
            List<string> list = new List<string>();
            if(hashsetValues.Contains(strs[i])){
                continue;
            }
            hashsetValues.Add(strs[i]);
            list.Add(strs[i]);
            char[] initialStringChar = strs[i].ToCharArray();
            Array.Sort(initialStringChar);

            for(int j = i+1; j<strs.Length; j++)        {

                char[] jStringChar = strs[j].ToCharArray();
                Array.Sort(jStringChar);
                bool equals = initialStringChar.SequenceEqual(jStringChar);
                if(equals){
                    list.Add(strs[j]);
                    hashsetValues.Add(strs[j]);
                }

            }
            resultList.Add(list);
        }
        return resultList;
    }
}
