using System;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book();
            Book Book2 = new Book();
            Book1.getValues("C Programming", "abc", "C Programming", 6495407);
            Book2.getValues("C# Programming", "abc", "C#", 6495700);
            Book1.display();
            Book2.display();

            Console.ReadKey();
        }
    }
}
