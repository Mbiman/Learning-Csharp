
// Overloaded method declarations

public class MethodOverload
{
    // test overloaded square methods
    public static void Main(String[] args)
    {
        Console.WriteLine("Square of integer 10 is {0}", Square(10));
        Console.WriteLine("Square of double 2.57 is {0}", Square(2.57));
    }// end main method

    //square method with int argument
    public static int Square(int intValue)
    {
        Console.WriteLine("Called square with int argument: {0}", intValue);
        return intValue * intValue;
    } //end square method with int argument

    //square method with double argument
    public static double Square (double doubleValue)
    {
        Console.WriteLine("Called square with double argument: {0}", doubleValue);
        return doubleValue * doubleValue;
    }// end square method with double argument
}// end class Methodoverload