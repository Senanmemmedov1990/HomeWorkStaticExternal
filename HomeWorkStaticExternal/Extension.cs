namespace HomeWorkStaticExternal;

internal static class Extension
{
    public static void Sadeeded(int eded)
    {
        int count = 0;
        for (int i = 2; i * i < eded; i++)
        {
            if (eded % 2 == 0)
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Eded sadedir");
        }
        else Console.WriteLine("Eded sade deyil");
    }
}
