namespace OOP2;

internal class Program
{
    private bool m(int x)
    {
        return x == 23;
    }
    
    
    public static void Main(string[] args)
    {
        int hi = int.Parse(Console.ReadLine());
        bool h = true;
        Console.WriteLine(hi);

        if (hi == 23)
            h = true;
        else
            h = false;
        
        
    }
}