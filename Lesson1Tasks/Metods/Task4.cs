/*Task 4:  "Bigger is Greater" bir setir melumat daxil edirsiz simvolları çeşidləməklə növbəti
             leksikoqrafik cəhətdən daha böyük permutasiyanın tap.*/
public static class Task4{
    public static void PrintBiggerİsGreater()
    {
        Console.Write("Bir setir melumat daxil edin:");
        string input= Console.ReadLine().Trim();
        string result = FindNextPermutation(input);
        Console.WriteLine("Növbəti leksikoqrafik cəhətdən daha böyük permutasiya: " + result);
    }
    public static string FindNextPermutation(string input)
    {
            char[] chars = input.ToCharArray();
            int i = chars.Length - 2;
            // 1. Sağdan sola doğru ilk azalan simvolu tap
            while (i >= 0 && chars[i] >= chars[i + 1])
            {
                i--;
            }
            // Əgər bütün simvollar azalmışdırsa, bu simvolun ən böyük permutasiyasıdır.
            if (i == -1)
            {
                return "no answer";
            }
            // 2. Yenə sağdan sola doğru gedərək, chars[i] dən böyük olan ilk simvolu tap
            int j = chars.Length - 1;
            while (chars[j] <= chars[i])
            {
                j--;
            }
            // 3. chars[i] və chars[j] -ni dəyiş
            Swap(chars, i, j);
            // 4. chars[i] -dən sağda olan bütün simvolları ters çevir
            Array.Reverse(chars, i + 1, chars.Length - i - 1);
            return new string(chars);
    }

        private static void Swap(char[] chars, int i, int j)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
}
