public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder str = new();
        foreach(string s in strs ){
            str.Append(s.Length);
            str.Append("#");
            str.Append(s);
        }

        return str.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0;
        while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }

            int length = int.Parse(s.Substring(i,j-i));
            j++;
            string st = s.Substring(j,length);
            result.Add(st);
            i = j + length;
        }
        return result;
   }
}
