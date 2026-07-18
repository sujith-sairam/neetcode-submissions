public class Solution {
    public bool IsAnagram(string s, string t) {
        int size = s.Length;

        if(size != t.Length){
            return false;
        }

        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();
        Array.Sort(sChar);
        Array.Sort(tChar);

        return sChar.SequenceEqual(tChar);

    }

}
