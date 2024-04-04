namespace HomeWorkStaticExternal;

internal static class Factorial
{
    public static void Faktorial(int eded)
    {
        int x = 1;
        for (int i = 1; i <= eded; i++)
        {
            x *= i;
        }
          Console.WriteLine(x);   
    }
}
