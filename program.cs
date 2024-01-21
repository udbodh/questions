using System.ComponentModel;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {

       
        Console.WriteLine(ascendingDigits(1234));
        Console.WriteLine(ascendingDigits(247));
        Console.WriteLine(ascendingDigits(-42423));
        Console.WriteLine(ascendingDigits(-1237));

        Console.WriteLine(isSarala(new int[] {5,13,6,7,5}));
        Console.WriteLine(c33(new int[] {3,5,-1}));
        Console.WriteLine(c33(new int[] {8,3,4}));


    }
    static int ascendingDigits(int n)
    {
        if (n < 0)
            n = -n;
        if (n < 10) return 1;
        int reverse = 0;
        while (n != 0)
        {
            reverse = 10 * reverse + n % 10;
            n /= 10;
        }
        int temp = reverse % 10;
        while (reverse != 0)
        {
            reverse /= 10;
            if (reverse == 0) break;
            if (reverse % 10 < temp)
                return 0;
            temp = reverse % 10;
        }
        return 1;
    }

    static int isSarala(int[] a)
    {
        int len = a.Length;
        if (len == 1)
        {
            if (a[0] == 5)
                return 0;
            else
                return 1;
        }
        bool isValid = true;
        for(int i = 0; i < len; i++)
        {
            if (a[i] == 5)
                isValid = false;
            if (a[i] == 5 && i + 1 < len && a[i + 1] != 13)
                return 0;
            if (a[i] == 5 && i + 1 < len && a[i + 1] == 13)
                isValid = true;
        }
        return isValid ? 1 : 0;
    }

    static int c33(int[] a)
    {
        if (a == null) return 0;
        foreach(int num1 in a)
        {
            foreach(int num2 in a)
                if(2*num1 == num2)
                    return 0;
        }
        return 1;
    }
}
