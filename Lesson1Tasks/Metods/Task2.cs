/* Task 2: Kart nömrəsinin etibarlılığının yoxlanılması. Yeni 16 reqemli Card nomresi olur onu yoxlamaq
 lazimdirki bu heqiqeten Kart nömresi ola bilermi ola bilmezmi (LUHN alqoritmi) */
public class Task2
{
    public static void PrintİsReliable(string cardNumber){
        if (Task2.IsValidCardNumber(cardNumber))
        {
                Console.WriteLine("Kart nömrəsi etibarlıdır.");
        }
        else
        {
                Console.WriteLine("Kart nömrəsi etibarsızdır.");
        }
    }
    public static bool IsValidCardNumber(string cardNumber)
    {
        // Kart nömrəsinin 16 rəqəmli uzunluqda olub olmadığını yoxla
        if (cardNumber.Length != 16)
        {
            return false;
        }
        // Kart nömrəsinin yalnız rəqəmlərdən ibarət olub olmadığını yoxla
        foreach (char c in cardNumber)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        // Luhn algorithm ni icra et
        int sum = 0;
        bool alternate = false;
        for (int i = cardNumber.Length - 1; i >= 0; i--)
        {
            int n = int.Parse(cardNumber.Substring(i, 1));

            if (alternate)
            {
                n *= 2;
                if (n > 9)
                {
                    n -= 9;
                }
            }
            sum += n;
            alternate = !alternate;
        }
        return sum % 10 == 0;
    }
}