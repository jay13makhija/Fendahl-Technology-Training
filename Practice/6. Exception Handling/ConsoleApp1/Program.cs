public class numberExpection:Exception
{
    public numberExpection(String message) : base (message)
    {
        Console.WriteLine("\nNummber Exeption\n");
    }
}

public class Exeption_jay
{



    
    public static void Main()
    {
        try
        {
            //code
            int x = 2;
            int y = 4;
            int z = 0;

            if (x % 2 == 0)
            {
                throw new numberExpection("\nNumber exception message\n");
            }
            Console.WriteLine(y / x);
        }
        
        catch (numberExpection ey)
        {
            //solution
            Console.WriteLine("\nCatch solution of number exeption\n");
        }
        
        finally
        {
            try
            {
                int y = 4;
                int z = 0;
                Console.WriteLine(y / z);
            }
            catch (DivideByZeroException ex)
            {
                //solution
                Console.WriteLine("\nCatch of divide by zero error\n");
            }
            Console.WriteLine("\nFinally executable code\n");
            //100% executable code
        }
        

    }
}