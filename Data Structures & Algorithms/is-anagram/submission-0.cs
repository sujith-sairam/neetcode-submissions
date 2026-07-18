public class Solution {
    public bool IsAnagram(string s, string t) {
        int size = s.Length;

        if(size != t.Length){
            return false;
        }

        Dictionary<char,int> sDict = new Dictionary<char,int>();
        Dictionary<char,int> tDict = new Dictionary<char,int>();

        for(int i=0; i < size; i++){
            sDict[s[i]] = sDict.GetValueOrDefault(s[i],0) + 1;
            tDict[t[i]] = tDict.GetValueOrDefault(t[i],0) + 1;
        }

        return sDict.Count == tDict.Count && !sDict.Except(tDict).Any();
    }
}
