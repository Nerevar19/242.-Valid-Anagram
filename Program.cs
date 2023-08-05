namespace _242._Valid_Anagram
{
    internal class Program
    {
        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false;

            var dict = new Dictionary<char, int>(s.Length);
            foreach( char ch in s )
            {
                if(!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                }
                else
                {
                    dict[ch]++;
                }
            }

            foreach(char ch in t)
            {
                if (!dict.ContainsKey(ch)) return false;
                dict[ch]--;
            }
            return !dict.Values.Any(n => n != 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}