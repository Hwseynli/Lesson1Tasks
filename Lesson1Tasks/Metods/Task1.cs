/* Task 1:  n ədəd var m dəfə bu ədədlərdən random seçirsən (n > 0 m >=0) bütün possible stateləri sadala
n = 3
m = 4

1,1,1,1
1,1,1,2
1,1,1,3
1,1,2,1
1,1,2,2
1,1,2,3
....
*/
class Task1
{
    private int n;
    private int m;

    public Task1(int n, int m)
    {
        this.n = n;
        this.m = m;
    }

    public void Generate()
    {
        int[] combination = new int[m];
        GenerateCombinations(combination, 0);
    }

    private void GenerateCombinations(int[] combination, int index)
    {
        if (index == m)
        {
            Console.WriteLine(string.Join(",", combination));
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            combination[index] = i;
            GenerateCombinations(combination, index + 1);
        }
    }
    static bool IsInteger(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
    public static int GetValidInteger(string prompt, Func<int, bool> condition)
    {
        int result = 0;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write(prompt);
            string input="";
            input = Console.ReadLine().Trim();
            
            if (IsInteger(input))
            {
                result = Convert.ToInt32(input);
                if (condition(result))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Ədəd tələb olunan şərtə cavab vermir. Yenidən cəhd elə.");
                }
            }
            else
            {
                Console.WriteLine("Yalnış ədəd. Etibarlı tam ədəd daxil edin.");
            }
        }
        return result;
    }
}