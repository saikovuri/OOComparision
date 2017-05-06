using System;
class BaseGC
{
    public void Display()
    {
        Console.WriteLine("Example Method");
    }
}

class GCExample2
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
            BaseGC oBaseGC = new BaseGC();
            Console.WriteLine("BaseGC Generation is :" + GC.GetGeneration(oBaseGC));
            Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
        }
        catch (Exception oEx)
        {
            Console.WriteLine("Error:" + oEx.Message);
        }
    }}
