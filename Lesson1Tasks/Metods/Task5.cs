//Task 5: Array-dəki min və max ədədlərin cəmini tapan funksiya yaz.
public static class Task5{
    public static void PrintSumMinMax(int size)
    {
         int[] numbers = new int[size];

        // İstifadəçidən array elementlərini istə
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine().Trim());
        }

        // Min və Max ədədləri tap
        int min = Task5.FindMin(numbers);
        int max = Task5.FindMax(numbers);

        // Min və Max ədədlərin cəmini hesabla
        int sum = min + max;

        // Nəticəni console-a yazdır
        Console.WriteLine($"Min ədəd: {min}");
        Console.WriteLine($"Max ədəd: {max}");
        Console.WriteLine($"Min və Max ədədlərin cəmi: {sum}");
    }

     public static int FindMin(int[] array)
    {
        int min = array[0];
        foreach (int num in array)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }

    public static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
}