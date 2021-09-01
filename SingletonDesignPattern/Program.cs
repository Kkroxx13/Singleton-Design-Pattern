using System;

namespace SingletonDesignPattern
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Singleton sl1 = Singleton.Instance();
            Singleton sl2 = Singleton.Instance();
            if(sl1==sl2)
                Console.WriteLine("Both objects are same");
            Console.ReadLine();
                
        }
    }
}
