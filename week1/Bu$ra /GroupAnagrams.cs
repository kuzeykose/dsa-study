using System.Collections.Generic;
using System.Linq;

public class Solution {
    public static IList<IList<string>> GroupAnagrams(string[] strs) {
        // Anagramları gruplandırmak için bir sözlük kullanacağız.
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            // String'i karakter dizisine çevirip sıralıyoruz.
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedStr = new string(charArray);

            // Sıralanmış string, aynı anagram grubundaki kelimeler için benzersiz bir anahtar oluşturur.
            if (!anagramGroups.ContainsKey(sortedStr)) {
                anagramGroups[sortedStr] = new List<string>();
            }

            anagramGroups[sortedStr].Add(str);
        }

        // Grupları bir liste olarak döndürüyoruz.
        return anagramGroups.Values.ToList<IList<string>>();
    }

    public static void Main() {
        // Örnek kullanım
        string[] strs1 = {"eat", "tea", "tan", "ate", "nat", "bat"};
        Console.WriteLine("Example 1:");
        PrintGroups(GroupAnagrams(strs1));

        string[] strs2 = {""};
        Console.WriteLine("\nExample 2:");
        PrintGroups(GroupAnagrams(strs2));

        string[] strs3 = {"a"};
        Console.WriteLine("\nExample 3:");
        PrintGroups(GroupAnagrams(strs3));
    }

    // Grupları yazdırmak için yardımcı bir fonksiyon
    public static void PrintGroups(IList<IList<string>> groups) {
        foreach (var group in groups) {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }
    }
}
