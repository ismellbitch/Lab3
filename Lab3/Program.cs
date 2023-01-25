using Lab3;

internal class Program
{
    private static void Main(string[] args)
    {
        Money money1 = new Money(10, 20);
        Money money2 = new Money(14, 80);
        Money money3 = (Money)money1.Add(money2);

        Complex complex1 = new Complex(1, 2);
        Complex complex2 = new Complex(2, 1);
        Complex complex3 = (Complex)complex1.Add(complex2);
    }
}