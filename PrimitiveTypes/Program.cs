namespace Exploring.BaseClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Primitive Data Types\n---------------------\n");

            #region Int

            Console.WriteLine($"int, System.Int16.....System.Int64\n-----------------------------------\n");

            int myInt = 1;
            var myIntType = myInt.GetType();

            Console.Write("Variable ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("myInt ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("has been declared as an int and the value of 1 has been assigned to it.\n\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("myInt ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"is of type: {myIntType.Name} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---- the keyword int is a C# alias that points to System.Int32.\n");

            Console.ForegroundColor = ConsoleColor.White;           
            Console.WriteLine($"System.Int32 is a Primitive Type:  {typeof(System.Int32).IsPrimitive}\n\n");

            #endregion

            #region string

            Console.WriteLine($"string, System.String\n----------------------\n");
            
            string myString = "this is my string";
            var myStringType = myString.GetType();

            Console.Write("Variable ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("myString ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("has been declared as a string and the value of 'this is my string' has been assigned to it.\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("myString ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"is of type: {myStringType.Name} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"--- the keyword string is a C# alias that points to System.String.\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"System.String is a Primitive Type:  {typeof(System.String).IsPrimitive}\n\n");

            #endregion

        }
    }
}