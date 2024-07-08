//Task3: Fibonachi tapilmasi
public static class Task3{
    public static void Printfibonachi(int count)
    {
        int[] fibonacciSequence = Task3.GenerateSequence(count);
        Console.WriteLine($"Fibonacci sırasının ilk {count} elementi:");
        foreach (int num in fibonacciSequence)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    public static int[] GenerateSequence(int count)
    {
        int[] fibonacci = new int[count];
        if (count >= 1)
            fibonacci[0] = 0;
        if (count >= 2)
            fibonacci[1] = 1;
        for (int i = 2; i < count; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        return fibonacci;
    }
}